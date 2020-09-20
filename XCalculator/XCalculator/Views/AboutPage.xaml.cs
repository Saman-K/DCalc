using System;

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


        private async void BtnMain_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}