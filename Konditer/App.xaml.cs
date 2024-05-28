using Konditer.Views;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Konditer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            if (!Preferences.Get("Login", false))
                MainPage = new Start_Auth();
            else
            {
                MainPage = new AppShell();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
