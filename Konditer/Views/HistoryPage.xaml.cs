using Konditer.Models;
using Plugin.Connectivity;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistoryPage : ContentPage
	{
        public string username = Preferences.Get("Username", string.Empty);
		public HistoryPage ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            int x = 0;

            DB db = new DB();

            try
            {
                long order_count = await db.GetCountOrderItem(username);

                for (int i = 1; i <= order_count; i++)
                {
                    var order_item = await db.GetOrderItem(i, Preferences.Get("Username", string.Empty));

                    if (order_item != null)
                    {
                        Order_Item order = new Order_Item(order_item.Id, order_item.Date, order_item.Summ);
                        order.frame.Opacity = 0;

                        TapGestureRecognizer tap = new TapGestureRecognizer();
                        tap.Command = new Command(async () =>
                        {
                            var isConn = CrossConnectivity.Current.IsConnected;

                            if (isConn)
                                await Navigation.PushAsync(new OrderContent(order_item.Id, order_item.Summ, order_item.Id_items));
                            else
                                await this.DisplayToastAsync("Проверьте подключение к интернету");
                        });

                        order.frame.Content.GestureRecognizers.Add(tap);

                        Grid.SetRow(order.frame, x);

                        order_grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                        order_grid.Children.Add(order.frame);

                        x++;

                        var animation = new Animation(v => order.frame.Opacity = v, 0, 1);
                        animation.Commit(this, "VisibleOrder", 16, 500, Easing.SinInOut, (v, c) => order.frame.Opacity = 1, () => false);
                    }
                }
            }
            catch
            {
                await this.DisplayToastAsync("История заказов пуста, оформите заказы, чтобы продолжить");
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            order_grid.Children.Clear();
        }
    }
}