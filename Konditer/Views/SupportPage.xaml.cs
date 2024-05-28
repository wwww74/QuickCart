using Konditer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SupportPage : ContentPage
	{
		public SupportPage ()
		{
			InitializeComponent ();
			this.BindingContext = new SupportPageViewModel();
		}
    }
}