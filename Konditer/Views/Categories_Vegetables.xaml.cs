using Konditer.Models;
using Plugin.Connectivity;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categories_Vegetables : ContentPage
    {
        public string username = Preferences.Get("Username", string.Empty);
        public Categories_Vegetables()
        {
            InitializeComponent();

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(3));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap1 = new TapGestureRecognizer();
            tap1.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(4));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap5 = new TapGestureRecognizer();
            tap5.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                {
                    DB db = new DB();

                    var basket_item = await db.GetBasketItem(3, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(3, 1, 167, 167, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 3);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                }
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap6 = new TapGestureRecognizer();
            tap6.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                {
                    DB db = new DB();

                    var basket_item = await db.GetBasketItem(4, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(4, 1, 175, 175, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 4);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                }
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            milkF.Content.GestureRecognizers.Add(tap);
            tomatoF.Content.GestureRecognizers.Add(tap1);
            milkB.Content.GestureRecognizers.Add(tap5);
            tomatoB.Content.GestureRecognizers.Add(tap6);
        }
    }
}