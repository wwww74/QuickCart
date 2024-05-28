using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Konditer.Models
{
    public class Basket
    {
        public Frame frame = new Frame();
        public Button inc_btn = new Button();
        public Button decr_btn = new Button();
        public Label price_label = new Label();
        public Label count_label = new Label();
        public Basket(string image, string name, int count, float price, bool isOrder)
        {
            frame.HasShadow = false;
            frame.HorizontalOptions = LayoutOptions.FillAndExpand;
            frame.VerticalOptions = LayoutOptions.CenterAndExpand;
            frame.Margin = new Thickness(-10, 10, -10, 0);
            frame.BackgroundColor = Color.FromHex("#fffafa");
            frame.BorderColor = Color.FromHex("#e0e0e0");

            Grid grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            Image img = new Image
            {
                Source = image,
                WidthRequest = 110,
                HeightRequest = 110
            };

            Grid.SetColumn(img, 0);

            Frame frame2 = new Frame
            {
                HasShadow = false,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = 0,
                BackgroundColor = Color.Transparent
            };

            Grid.SetColumn(frame2, 1);

            Grid grid2 = new Grid();

            grid2.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid2.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            Label names = new Label
            {
                Text = name,
                TextColor = Color.FromHex("#252525"),
                FontSize = 20,
                WidthRequest = 110
            };

            Grid.SetRow(names, 0);
            grid2.Children.Add(names);

            Frame frame3 = new Frame
            {
                HasShadow = false,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                CornerRadius = 20,
                Padding = 0,
                WidthRequest = 130,
                HeightRequest = 40,
                Margin = new Thickness(-10, 20, -30, 0),
                BorderColor = Color.FromHex("#252525")
            };

            Grid.SetRow(frame3, 1);

            Grid grid3 = new Grid
            {
                Padding = new Thickness(0, 5, 0, 0)
            };

            grid3.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid3.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            grid3.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid3.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            if (!isOrder)
            {
                inc_btn.BackgroundColor = Color.Transparent;
                inc_btn.HorizontalOptions = LayoutOptions.EndAndExpand;
                inc_btn.VerticalOptions = LayoutOptions.CenterAndExpand;
                inc_btn.Text = "+";
                inc_btn.TextColor = Color.FromHex("#252525");
                inc_btn.FontFamily = "EvolveBold";
                inc_btn.FontSize = 25;
                inc_btn.WidthRequest = 40;
                inc_btn.HeightRequest = 40;
                inc_btn.Margin = new Thickness(0, -12, 0, 0);

                Grid.SetRow(inc_btn, 0);
                Grid.SetColumn(inc_btn, 0);

                decr_btn.BackgroundColor = Color.Transparent;
                decr_btn.HorizontalOptions = LayoutOptions.StartAndExpand;
                decr_btn.VerticalOptions = LayoutOptions.CenterAndExpand;
                decr_btn.Text = "-";
                decr_btn.TextColor = Color.FromHex("#252525");
                decr_btn.FontFamily = "EvolveBold";
                decr_btn.FontSize = 25;
                decr_btn.WidthRequest = 40;
                decr_btn.HeightRequest = 40;
                decr_btn.Margin = new Thickness(0, -12, 0, 0);

                Grid.SetRow(decr_btn, 0);
                Grid.SetColumn(inc_btn, 2);

                count_label.Text = count.ToString();
                count_label.TextColor = Color.FromHex("#252525");
                count_label.FontFamily = "EvolveBold";
                count_label.FontSize = 20;
                count_label.HorizontalOptions = LayoutOptions.CenterAndExpand;
                count_label.VerticalOptions = LayoutOptions.CenterAndExpand;

                price_label.Text = price.ToString() + "₽";
                price_label.TextColor = Color.FromHex("#252525");
                price_label.FontFamily = "EvolveBold";
                price_label.FontSize = 23;
                price_label.HorizontalOptions = LayoutOptions.EndAndExpand;
                price_label.Margin = new Thickness(0, 0, 15, 0);

                grid3.Children.Add(decr_btn);
                grid3.Children.Add(inc_btn);
                grid3.Children.Add(count_label);

                Grid.SetRow(count_label, 0);
                Grid.SetColumn(count_label, 1);
                Grid.SetColumn(price_label, 2);

                grid.Children.Add(price_label);

                frame3.Content = grid3;

                grid2.Children.Add(frame3);
            }
            frame2.Content = grid2;

            grid.Children.Add(frame2);
            grid.Children.Add(img);

            frame.Content = grid;
        }
    }
}
