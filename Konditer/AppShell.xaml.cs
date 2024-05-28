using Konditer.Views;
using Xamarin.Forms;

namespace Konditer
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("//Categories_Bakalea", typeof(Categories_Bakalea));
            Routing.RegisterRoute("//Categories_Milk", typeof(Categories_Milk));
            Routing.RegisterRoute("//Categories_Meat", typeof(Categories_Meat));
            Routing.RegisterRoute("//Categories_Vegetables", typeof(Categories_Vegetables));
            Routing.RegisterRoute("//Other_SaleItem", typeof(Other_SaleItem));
        }
    }
}
