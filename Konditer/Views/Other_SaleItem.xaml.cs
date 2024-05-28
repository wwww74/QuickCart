﻿using Konditer.Models;
using Plugin.Connectivity;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Other_SaleItem : ContentPage
    {
        public string username = Preferences.Get("Username", string.Empty);
        public Other_SaleItem()
        {
            InitializeComponent();

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(1));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap1 = new TapGestureRecognizer();
            tap1.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(3));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap2 = new TapGestureRecognizer();
            tap2.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(5));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap3 = new TapGestureRecognizer();
            tap3.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(7));
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap4 = new TapGestureRecognizer();
            tap4.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                    await Navigation.PushAsync(new ProductPage(9));
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

                    var basket_item = await db.GetBasketItem(1, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(1, 1, 96, 96, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 1);
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

            TapGestureRecognizer tap7 = new TapGestureRecognizer();
            tap7.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                {
                    DB db = new DB();

                    var basket_item = await db.GetBasketItem(5, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(5, 1, 141, 141, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 5);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                }
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            TapGestureRecognizer tap8 = new TapGestureRecognizer();
            tap8.Command = new Command(async () =>
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

            TapGestureRecognizer tap9 = new TapGestureRecognizer();
            tap9.Command = new Command(async () =>
            {
                var isConn = CrossConnectivity.Current.IsConnected;

                if (isConn)
                {
                    DB db = new DB();

                    var basket_item = await db.GetBasketItem(9, username);

                    if (basket_item == null)
                    {
                        await db.AddBasketItem(9, 1, 329, 329, username);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                    else if (basket_item != null)
                    {
                        int count = basket_item.Count + 1;
                        float last_price = basket_item.End_Price + basket_item.Start_Price;
                        await db.AddMoreBasketItem(count, last_price, 9);
                        await this.DisplayToastAsync("Товар успешно добавлен в корзину!");
                    }
                }
                else
                    await this.DisplayToastAsync("Проверьте подключение к интернету");
            });

            milkF.Content.GestureRecognizers.Add(tap);
            tomatoF.Content.GestureRecognizers.Add(tap1);
            eggF.Content.GestureRecognizers.Add(tap2);
            makaroniF.Content.GestureRecognizers.Add(tap3);
            chikenF.Content.GestureRecognizers.Add(tap4);
            milkB.Content.GestureRecognizers.Add(tap5);
            tomatoB.Content.GestureRecognizers.Add(tap6);
            eggB.Content.GestureRecognizers.Add(tap7);
            makaroniB.Content.GestureRecognizers.Add(tap8);
            chikenB.Content.GestureRecognizers.Add(tap9);
        }
    }
}