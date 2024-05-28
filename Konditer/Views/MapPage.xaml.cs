using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var loc = await Geolocation.GetLocationAsync();
            Position pos = new Position(loc.Latitude, loc.Longitude);

            MapSpan mapSpan = new MapSpan(pos, 0.01, 0.01);
            Xamarin.Forms.Maps.Map myMap = new Xamarin.Forms.Maps.Map(mapSpan);

            myMap.IsShowingUser = true;
            myMap.HasZoomEnabled = true;

            Pin shop1 = new Pin //bar
            {
                Label = "Продуктовый магазин 'QuickCart'",
                Address = "Байкальская ул., 107, Иркутск, Иркутская обл., 664047",
                Type = PinType.Place,
                Position = new Position(52.26702654993806, 104.30997797286332)
            };

            Pin shop2 = new Pin //mol
            {
                Label = "Продуктовый магазин 'QuickCart'",
                Address = "ул. Верхняя Набережная, 10, Иркутск, Иркутская обл., 664022",
                Type = PinType.Place,
                Position = new Position(52.268206230126424, 104.28979499274857)
            };

            Pin shop3 = new Pin //mk
            {
                Label = "Продуктовый магазин 'QuickCart'",
                Address = "ул. 3 Июля, 25, Иркутск, Иркутская обл., 664022",
                Type = PinType.Place,
                Position = new Position(52.2735641711913, 104.29103105355152)
            };

            Pin shop4 = new Pin //new
            {
                Label = "Продуктовый магазин 'QuickCart'",
                Address = "Советская ул., 58/1, Иркутск, Иркутская обл., 664047",
                Type = PinType.Place,
                Position = new Position(52.276295081024436, 104.30527894749022)
            };

            myMap.Pins.Add(shop1);
            myMap.Pins.Add(shop2);
            myMap.Pins.Add(shop3);
            myMap.Pins.Add(shop4);

            mapGrid.Children.Add(myMap);
        }
    }
}