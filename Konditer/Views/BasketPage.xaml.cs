using Konditer.Models;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasketPage : ContentPage
	{
        public string username = Preferences.Get("Username", string.Empty);
        public string order_content = "";
		public BasketPage ()
		{
			InitializeComponent ();
		}

        public string TrimString(string str)
        {
            String stroke = str;
            char[] chars = { '₽' };
            string correct_str = stroke.TrimEnd(chars);

            return correct_str;
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) //clear basket
        {
            DB db = new DB();

            bool result = await DisplayAlert("Очистка корзины", "Вы хотите очистить корзину?", "Да", "Нет");

            if (result)
            {
                if (itemsGrid.Children.Count > 0)
                {
                    itemsGrid.Children.Clear();
                    await db.ClearBasket(username);
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
                else
                {
                    await this.DisplayToastAsync("Корзина пуста!");
                }
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            int x = 0;

            DB db = new DB();

            try
            {
                long basket_item_count = await db.GetCountBasketItem(username);
                float last_price = await db.GetPriceBasketItems(username);
                long count_item = await db.GetCountItems(username);

                startL.Text = $"В корзине {count_item} продуктов на {last_price} ₽";
                lastPriceL.Text = last_price.ToString() + "₽";

                for (int i = 1; i <= basket_item_count; i++)
                {
                    var basket_item = await db.GetBasketItem(i, Preferences.Get("Username", String.Empty));

                    if (basket_item != null)
                    {
                        Basket basket = new Basket(basket_item.Image, basket_item.Name, basket_item.Count, basket_item.End_Price, false);
                        basket.frame.Opacity = 0;

                        order_content += basket_item.Id_Item + ",";

                        string correct_price = TrimString(basket_item.Start_Price.ToString());

                        basket.inc_btn.Clicked += (s, e) =>
                        {
                            int count = Convert.ToInt32(basket.count_label.Text);

                            if (count < 10)
                            {
                                string correct_chena = TrimString(basket.price_label.Text);
                                int start_count = count;

                                count++;

                                count_item = (count_item - start_count) + count;

                                basket.price_label.Text = (count * Convert.ToInt32(correct_price)).ToString();
                                basket.count_label.Text = count.ToString();

                                string l_p = TrimString(lastPriceL.Text);

                                lastPriceL.Text = ((Convert.ToSingle(l_p) - Convert.ToSingle(correct_chena)) + Convert.ToSingle(basket.price_label.Text)).ToString();

                                startL.Text = $"В корзине {count_item} продуктов на {lastPriceL.Text} ₽";

                                lastPriceL.Text += "₽";
                                basket.price_label.Text += "₽";
                            }
                        };
                        basket.decr_btn.Clicked += (s, e) =>
                        {
                            int count = Convert.ToInt32(basket.count_label.Text);

                            if (count > 1)
                            {
                                string correct_chena = TrimString(basket.price_label.Text);
                                int start_count = count;

                                count--;

                                count_item = (count_item - start_count) + count;

                                basket.price_label.Text = (count * Convert.ToInt32(correct_price)).ToString();
                                basket.count_label.Text = count.ToString();

                                string l_p = TrimString(lastPriceL.Text);

                                lastPriceL.Text = ((Convert.ToSingle(l_p) - Convert.ToSingle(correct_chena)) + Convert.ToSingle(basket.price_label.Text)).ToString();

                                startL.Text = $"В корзине {count_item} продуктов на {lastPriceL.Text} ₽";

                                lastPriceL.Text += "₽";
                                basket.price_label.Text += "₽";
                            }
                        };

                        Grid.SetRow(basket.frame, x);

                        itemsGrid.Children.Add(basket.frame);

                        x++;

                        var animation = new Animation(v => basket.frame.Opacity = v, 0, 1);
                        animation.Commit(this, "VisibleBasketItem", 16, 1000, Easing.SinInOut, (v, c) => basket.frame.Opacity = 1, () => false);
                    }
                }
                orderF.IsVisible = true;
            }
            catch
            {
                orderF.IsVisible = false;
                startL.Text = $"В корзине 0 продуктов на 0 ₽";
                lastPriceL.Text = "0₽";
                await this.DisplayToastAsync("Корзина пуста, добавьте товары, чтобы продолжить");
            }
        }

        protected async override void OnDisappearing()
        {
            base.OnDisappearing();

            order_content = "";
            itemsGrid.Children.Clear();
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e) //add order
        {
            float summ = Convert.ToSingle(TrimString(lastPriceL.Text));

            DB db = new DB();

            bool result = await DisplayAlert("Оформление заказа", "Вы хотите оформить заказ?", "Да", "Нет");
            
            if (result)
            {
                await this.DisplayToastAsync("Заказ успешно добавлен!");
                await db.AddOrder(summ, order_content, username);
                await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                await db.ClearBasket(username);
            }
        }
    }
}