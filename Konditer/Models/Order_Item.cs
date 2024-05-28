using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Konditer.Models
{
    public class Order_Item
    {
        public Frame frame = new Frame();
        public Order_Item(int order_num, string order_date, float order_price)
        {
            frame.HasShadow = true;
            frame.BackgroundColor = Color.FromHex("#FFFAFA");
            frame.HorizontalOptions = LayoutOptions.FillAndExpand;
            frame.VerticalOptions = LayoutOptions.CenterAndExpand;
            frame.CornerRadius = 15;
            frame.BorderColor = Color.FromHex("#c0c0c0");
            frame.Margin = new Thickness(10, 10, 10, 0);
            frame.Padding = 0;

            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            Label number_order = new Label
            {
                Text = "Заказ #" + order_num.ToString(),
                TextColor = Color.FromHex("#252525"),
                FontFamily = "EvolveBold",
                FontSize = 30,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 10, 0, 0),
            };

            Label date_order = new Label
            {
                Text = order_date,
                TextColor = Color.FromHex("#252525"),
                FontFamily = "EvolveBold",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 10, 20, 0),
            };

            Label price_order = new Label
            {
                Text = order_price.ToString() + "₽",
                TextColor = Color.FromHex("#a0a0a0"),
                FontFamily = "EvolveBold",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 0, 0, 10),
            };

            Grid.SetRow(number_order, 0);
            Grid.SetRow(date_order, 0);
            Grid.SetRow(price_order, 1);

            grid.Children.Add(number_order);
            grid.Children.Add(date_order);
            grid.Children.Add(price_order);

            frame.Content = grid;
        }
    }
}
