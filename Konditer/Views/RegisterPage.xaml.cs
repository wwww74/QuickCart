using Konditer.Models;
using Plugin.Connectivity;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e) //reg
        {
            CheckConnectivity();
        }

        private void Button_Clicked1(object sender, EventArgs e) //prev page
        {
            Application.Current.MainPage = new Start_Auth();
        }

        private async void CheckConnectivity()
        {
            var isConnected = CrossConnectivity.Current.IsConnected;

            try
            {
                if (isConnected)
                {
                    if (loginE.Text != null && passwordE.Text != null)
                    {
                        DB db = new DB();
                        if (db != null)
                        {
                            var user = await db.GetUser(loginE.Text);
                            if (user == null)
                            {
                                if (loginE.Text.Length < 3 || passwordE.Text.Length < 3 || passwordE.Text.Length > 10)
                                {
                                    await DisplayAlert("Упс...", "Поле 'Логин' должно содержать минимум 3 символа, а поле 'Пароль' минимум 3 и максимум 10 символов!", "ОК");
                                }
                                else
                                {
                                    try
                                    {
                                        await db.Add_User(new User { Username = loginE.Text, Password = passwordE.Text });
                                        await this.DisplayToastAsync("Регистрация прошла успешно! Вы можете авторизироваться!");
                                        Application.Current.MainPage = new Start_Auth();
                                    }
                                    catch
                                    {
                                        await this.DisplayToastAsync("Произошла ошибка при регистрации, повторите попытку позже :(");
                                    }
                                }
                            }
                            else
                                await this.DisplayToastAsync("К сожалению, введенное вами имя уже занято!");
                        }
                        else
                            await this.DisplayToastAsync("Произошла ошибка, попробуйте позже!");
                    }
                    else
                        await this.DisplayToastAsync("Пожалуйста, заполните все поля!");
                }
                else
                    await this.DisplayToastAsync("Отсутствует подключение к интернету");
            }
            catch
            {
                await this.DisplayToastAsync("Произошла ошибка на сервере, попробуйте позже");
                Application.Current.MainPage = new Start_Auth();
            }
        }
    }
}