using Konditer.Models;
using Plugin.Connectivity;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categories_Bakalea : ContentPage
    {
        public string username = Preferences.Get("Username", string.Empty);
        public Categories_Bakalea()
        {
            InitializeComponent();

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(7));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap1 = new TapGestureRecognizer();
            tap1.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(8));
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

                    var basket_item = await db.GetBasketItem(7, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(7, 1, 84, 84, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 7);
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

                    var basket_item = await db.GetBasketItem(8, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(8, 1, 81, 81, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 8);
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