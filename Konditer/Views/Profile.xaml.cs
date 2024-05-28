using Konditer.Models;
using Plugin.Connectivity;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Konditer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        bool isState = false;
        bool isEdit = false;

        public string name = "";
        public string mail = "";
        public string number = "";

        public Label name_label = new Label();
        public Label mail_label = new Label();
        public Label number_label = new Label();
        public Label personal_name = new Label();
        public Label personal_mail = new Label();
        public Label personal_number = new Label();
        public Grid Personal_Info_Grid = new Grid();
        public Profile()
        {
            InitializeComponent();
        }

        private async void CheckConnectivity()
        {
            var isConnected = CrossConnectivity.Current.IsConnected;

            try
            {
                if (isConnected)
                {
                    Personal_Body_Grid.Children.Clear();
                    LoadForm_Conn();
                }
                else
                {
                    await this.DisplayToastAsync("Проверьте подключение к интернету!");
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                }
            }

            catch
            {
                await DisplayAlert("Упс...", "Произошла ошибка подключения к серверу", "OK");
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            isEdit = false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CheckConnectivity();
        }

        private async void LoadForm_Conn()
        {
            if (Preferences.Get("Login", false))
            {
                close_acc.IsVisible = true;

                DB db = new DB();
                if (db != null)
                {
                    var user = await db.GetUser(Preferences.Get("Username", string.Empty));

                    if (user != null)
                    {
                        Frame Personal_Info = new Frame
                        {
                            HasShadow = true,
                            CornerRadius = 10,
                            Margin = new Thickness(0, 20, 0, 0),
                        };

                        Label personal_info_label = new Label
                        {
                            Text = "Личная информация",
                            TextColor = Color.FromHex("#252525"),
                            FontSize = 20,
                        };

                        name_label.Text = "Имя: ";
                        name_label.TextColor = Color.FromHex("#252525");
                        name_label.FontSize = 17;
                        name_label.Margin = new Thickness(0, 10, 0, 0);

                        mail_label.Text = "Почта: ";
                        mail_label.TextColor = Color.FromHex("#252525");
                        mail_label.FontSize = 17;
                        mail_label.Margin = new Thickness(0, 10, 0, 0);

                        number_label.Text = "Телефон: ";
                        number_label.TextColor = Color.FromHex("#252525");
                        number_label.FontSize = 17;
                        number_label.Margin = new Thickness(0, 10, 0, 0);

                        Label main_name = new Label
                        {
                            TextColor = Color.FromHex("#252525"),
                            FontSize = 25,
                            HorizontalOptions = LayoutOptions.CenterAndExpand,
                            Margin = new Thickness(0, 50, 0, 0)
                        };

                        if (user.Name == null)
                            main_name.Text = "Username";
                        else
                            main_name.Text = user.Name;

                        personal_name.Text = user.Name;
                        personal_name.TextColor = Color.FromHex("#252525");
                        personal_name.FontSize = 17;
                        personal_name.Margin = new Thickness(45, 10, 0, 0);

                        personal_mail.Text = user.Email;
                        personal_mail.TextColor = Color.FromHex("#252525");
                        personal_mail.FontSize = 17;
                        personal_mail.Margin = new Thickness(60, 10, 0, 0);

                        personal_number.Text = user.Phone;
                        personal_number.TextColor = Color.FromHex("#252525");
                        personal_number.FontSize = 17;
                        personal_number.Margin = new Thickness(75, 10, 0, 0);

                        Grid.SetRow(personal_info_label, 0);
                        Grid.SetRow(name_label, 1);
                        Grid.SetRow(mail_label, 2);
                        Grid.SetRow(number_label, 3);
                        Grid.SetRow(Personal_Info, 1);
                        Grid.SetRow(main_name, 0);
                        Grid.SetRow(personal_name, 1);
                        Grid.SetRow(personal_mail, 2);
                        Grid.SetRow(personal_number, 3);
                        Grid.SetRow(Frame_name, 1);
                        Grid.SetRow(Frame_mail, 2);
                        Grid.SetRow(Frame_number, 3);
                        Grid.SetRow(exit_btn, 4);
                        Grid.SetRow(save_btn, 4);

                        Personal_Info_Grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                        Personal_Info_Grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                        Personal_Info_Grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                        Personal_Info_Grid.Children.Add(Frame_name);
                        Personal_Info_Grid.Children.Add(Frame_mail);
                        Personal_Info_Grid.Children.Add(Frame_number);
                        Personal_Info_Grid.Children.Add(exit_btn);
                        Personal_Info_Grid.Children.Add(save_btn);
                        Personal_Info_Grid.Children.Add(personal_info_label);
                        Personal_Info_Grid.Children.Add(name_label);
                        Personal_Info_Grid.Children.Add(mail_label);
                        Personal_Info_Grid.Children.Add(number_label);
                        Personal_Info_Grid.Children.Add(personal_name);
                        Personal_Info_Grid.Children.Add(personal_mail);
                        Personal_Info_Grid.Children.Add(personal_number);

                        Personal_Info.Content = Personal_Info_Grid;

                        Personal_Body_Grid.Children.Add(main_name);
                        Personal_Body_Grid.Children.Add(Personal_Info);
                    }
                    else
                        await DisplayAlert("Упс...", "Произошла ошибка, попробуйте позже!", "ОК");
                }
                else
                    await DisplayAlert("Упс...", "Произошла ошибка, попробуйте позже!", "ОК");
            }
        }
        private void Img_btn_Clicked(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                name_label.IsVisible = false;
                mail_label.IsVisible = false;
                number_label.IsVisible = false;
                personal_name.IsVisible = false;
                personal_mail.IsVisible = false;
                personal_number.IsVisible = false;

                Frame_name.IsVisible = true;
                Frame_mail.IsVisible = true;
                Frame_number.IsVisible = true;
                exit_btn.IsVisible = true;
                save_btn.IsVisible = true;

                Entry_name.Text = personal_name.Text;
                Entry_mail.Text = personal_mail.Text;
                Entry_number.Text = personal_number.Text;
                Personal_Info_Grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            }
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Выход", "Вы уверены что хотите выйти?", "Да", "Нет");
            if (result)
            {
                if (Preferences.Get("Login", true))
                {
                    Preferences.Clear();
                    Preferences.Set("Login", false);
                    Application.Current.MainPage = new Start_Auth();
                }
                else
                {
                    await this.DisplayToastAsync("Кажется, вы уже вышли из профиля!");
                }
            }
        }

        private void exit_btn_Clicked(object sender, EventArgs e)
        {
            isEdit = false;

            name_label.IsVisible = true;
            mail_label.IsVisible = true;
            number_label.IsVisible = true;
            personal_name.IsVisible = true;
            personal_mail.IsVisible = true;
            personal_number.IsVisible = true;

            Frame_name.IsVisible = false;
            Frame_mail.IsVisible = false;
            Frame_number.IsVisible = false;
            exit_btn.IsVisible = false;
            save_btn.IsVisible = false;

            personal_name.Text = name;
            personal_mail.Text = mail;
            personal_number.Text = number;
        }

        private async void save_btn_Clicked(object sender, EventArgs e)
        {
            DB db = new DB();
            if (db != null)
            {
                await db.UpdateUserInfo(Entry_name.Text, Entry_mail.Text, Entry_number.Text, Preferences.Get("Username", string.Empty));

                isEdit = false;

                name_label.IsVisible = true;
                mail_label.IsVisible = true;
                number_label.IsVisible = true;
                personal_name.IsVisible = true;
                personal_mail.IsVisible = true;
                personal_number.IsVisible = true;

                Frame_name.IsVisible = false;
                Frame_mail.IsVisible = false;
                Frame_number.IsVisible = false;
                exit_btn.IsVisible = false;
                save_btn.IsVisible = false;
                Personal_Info_Grid.RowDefinitions.RemoveAt(3);

                CheckConnectivity();
                await this.DisplayToastAsync("Данные успешно сохранены");
            }
            else
                await this.DisplayToastAsync("Ошибка подключения к серверу, попробуйте позже");
        }
    }
}