using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity;
using Xamarin.Essentials;
using Xamarin.CommunityToolkit.Extensions;
using Konditer.Models;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Start_Auth : ContentPage
    {
        public Start_Auth()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e) //reset pass
        {
            await this.DisplayToastAsync("Для сброса пароля, обратитесь в тех.поддержку");
        }

        private void Button_Clicked(object sender, EventArgs e) //auth
        {
            CheckConnectivity();
        }

        private void Button_Clicked_1(object sender, EventArgs e) //reg
        {
            Application.Current.MainPage = new RegisterPage();
        }

        private async void CheckConnectivity()
        {
            var isConnected = CrossConnectivity.Current.IsConnected;
            try
            {
                if (isConnected)
                {
                    if (loginE.Text == null || passwordE.Text == null)
                        await this.DisplayToastAsync("Одно из полей не заполнено, попробуйте снова");
                    else
                    {
                        DB db = new DB();
                        var user = await db.GetUser(loginE.Text);
                        if (user != null)
                        {
                            if (user.Username == loginE.Text && user.Password == passwordE.Text)
                            {
                                Preferences.Set("Login", true);
                                Preferences.Set("Username", loginE.Text);
                                Preferences.Set("UserPass", passwordE.Text);

                                Application.Current.MainPage = new AppShell();
                            }
                            else
                            {
                                await this.DisplayToastAsync("Неверный логин или пароль :(");
                            }
                        }
                        else
                            await this.DisplayToastAsync("Неверный логин или пароль :(");
                    }
                }
                else
                    await this.DisplayToastAsync("Отсутствует подключение к интернету");
            }
            catch
            {
                await this.DisplayToastAsync("Произошла ошибка, попробуйте позже");
            }
        }
    }
}