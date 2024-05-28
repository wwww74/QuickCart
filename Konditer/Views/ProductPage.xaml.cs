using Konditer.Models;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public int id_item = 0;
        public string username = Preferences.Get("Username", string.Empty);
        public ProductPage(int id)
        {
            id_item = id;
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            DB db = new DB();

            var item = await db.GetItem(id_item);
            var sale_item = await db.GetSaleItem(id_item);

            if (item != null)
            {
                item_image.Source = item.Image;
                item_name.Text = item.Name;
                ccalL.Text = item.Ccal.ToString();
                belokL.Text = item.Belok.ToString();
                uglevodL.Text = item.Uglevod.ToString();
                jirL.Text = item.Jir.ToString();
                sostavL.Text = item.Sostav.ToString();
                srokL.Text = item.Srok.ToString();
                proizvodL.Text = item.Proizod.ToString();
                countL.Text = "1";
                summaL.Text = "0";

                if (sale_item != null)
                {
                    item_price.Text = (Convert.ToInt32(sale_item.Price) - ((Convert.ToInt32(sale_item.Price) * Convert.ToInt32(sale_item.Count_Sale)) / 100)).ToString();
                    summaL.Text = (1 * Convert.ToInt32(item_price.Text)).ToString() + "₽";
                    item_price.Text += "₽";
                    item_price.TextColor = Color.FromHex("#f97bcf");
                }
                else
                {
                    item_price.Text = item.Price.ToString();
                    summaL.Text = (1 * Convert.ToInt32(item_price.Text)).ToString() + "₽";
                    item_price.Text += "₽";
                    item_price.TextColor = Color.FromHex("#252525");
                }
            }
            else
            {
                await this.DisplayToastAsync("произошла ошибка");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e) //add basket
        {
            DB db = new DB();

            var basket_item = await db.GetBasketItem(id_item, username);

            if (basket_item == null)
            {
                int count = Convert.ToInt32(countL.Text);

                String start_price = item_price.Text;
                char[] chars = { '₽' };
                string correct_price = start_price.TrimEnd(chars);

                String end_price = summaL.Text;
                char[] charss = { '₽' };
                string correct_prices = end_price.TrimEnd(charss);

                await db.AddBasketItem(id_item, count, Convert.ToSingle(correct_price), Convert.ToSingle(correct_prices), username);
                await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
            }
            else if(basket_item != null)
            {
                int count = basket_item.Count + Convert.ToInt32(countL.Text);

                String price = summaL.Text;
                char[] charss = { '₽' };
                string correct_prices = price.TrimEnd(charss);

                float end_price = basket_item.End_Price + Convert.ToSingle(correct_prices);

                await db.AddMoreBasketItem(count, end_price, basket_item.Id_Item);
                await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e) //dec count
        {
            int count = Convert.ToInt32(countL.Text);

            if (count > 1)
            {
                count--;
                String price = item_price.Text;
                char[] chars = { '₽' };
                string correct_price = price.TrimEnd(chars);
                summaL.Text = (count * Convert.ToInt32(correct_price)).ToString() + "₽";
                countL.Text = count.ToString();
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e) //inc count
        {
            int count = Convert.ToInt32(countL.Text);

            if (count < 10)
            {
                count++;
                String price = item_price.Text;
                char[] chars = { '₽' };
                string correct_price = price.TrimEnd(chars);
                summaL.Text = (count * Convert.ToInt32(correct_price)).ToString() + "₽";
                countL.Text = count.ToString();
            }
        }
    }
}