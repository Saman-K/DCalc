using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        // Shows the main Window
        private async void BtnMain_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        // Opens SamanK.me website
        public async void Website_Click(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://samank.me/Code"));
        }
        // Opens github website
        public async void Github_click(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://github.com/Saman-K"));
        }
    }
}