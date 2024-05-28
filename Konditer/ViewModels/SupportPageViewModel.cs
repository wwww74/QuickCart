using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Konditer.ViewModels
{
    public class SupportPageViewModel
    {
        public ICommand Open_MaxAcc { get; }
        public SupportPageViewModel()
        {
            Open_MaxAcc = new Command(async () => await Browser.OpenAsync("https://t.me/wwww74"));
        }
    }
}
