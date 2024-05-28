using Konditer.Models;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderContent : ContentPage
	{
		public int order_id = 0;
        public float price = 0;
        public string id_items = "";
        public string username = Preferences.Get("Username", string.Empty);
		public OrderContent (int id, float summ, string id_item)
		{
			order_id = id;
            price = summ;
            id_items = id_item;
			InitializeComponent();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) //delete order
        {
            DB db = new DB();

            bool result = await DisplayAlert("Удаление заказа", "Вы хотите удалить заказ?", "Да", "Нет");
            if (result)
            {
                await db.DeleteOrder(order_id, username);
                await Shell.Current.GoToAsync($"//{nameof(HistoryPage)}");
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            int x = 0;

            DB db = new DB();

            try
            {
                startL.Text = $"Содержимое заказа #{order_id}";
                priceL.Text = price.ToString() + "₽";

                string[] id_item = id_items.Split(',');

                for (int i = 0; i < id_item.Length - 1; i++)
                {
                    int id = Convert.ToInt32(id_item[i]);
                    var basket_item = await db.GetOrderContentItem(id);

                    if (basket_item != null)
                    {
                        Basket basket = new Basket(basket_item.Image, basket_item.Name, 0, 0, true);
                        basket.frame.Opacity = 0;

                        Grid.SetRow(basket.frame, x);

                        itemsGrid.Children.Add(basket.frame);

                        x++;

                        var animation = new Animation(v => basket.frame.Opacity = v, 0, 1);
                        animation.Commit(this, "VisibleBasketItem", 16, 1000, Easing.SinInOut, (v, c) => basket.frame.Opacity = 1, () => false);
                    }
                }
            }
            catch
            {
                await this.DisplayToastAsync("Произошла ошибка, попробуйте позже");
            }
        }

        protected override void OnDisappearing()
		{
			base.OnDisappearing();

            itemsGrid.Children.Clear();
		}
    }
}