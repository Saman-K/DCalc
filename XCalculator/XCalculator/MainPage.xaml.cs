using DCalc.Views;
using System;
using Xamarin.Forms;

namespace DCalc
{
    public partial class MainPage : ContentPage
    {
        string oprationPerformed;
        Double? resultValue = null;
        Double? lastresultValue = null;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        // Value button
        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (Editor.Text == "0" && button.Text == ".") { }
            else if (Editor.Text == "0")
            {
                Editor.Text = "";
            }

            if (button.Text == ".")
            {
                if (!Editor.Text.Contains("."))
                {
                    Editor.Text = Editor.Text + button.Text;
                }
            }
            else
            {
                Editor.Text = Editor.Text + button.Text;
            }
        }
        // Operator button
        private void Operator_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;


            if (Editor.Text == "0" || Editor.Text == "" || Editor.Text == "." || Editor.Text == "0.")
            {
                oprationPerformed = button.Text;
            }
            else if ((resultValue == 0 || resultValue == null) && button.Text != "=" && (Editor.Text != "0" || Editor.Text != "" || Editor.Text != "." || Editor.Text != "0."))
            {
                resultValue = Double.Parse(Editor.Text);
                oprationPerformed = button.Text;
                Editor.Text = "0";
            }
            else if ((lastresultValue == 0 || lastresultValue == null) && (Editor.Text != "0" || Editor.Text != "" || Editor.Text != "." || Editor.Text != "0."))
            {
                switch (oprationPerformed)
                {
                    case "+":
                        lastresultValue = (resultValue + Double.Parse(Editor.Text));
                        break;
                    case "-":
                        lastresultValue = (resultValue - Double.Parse(Editor.Text));
                        break;
                    case "÷":
                        lastresultValue = (resultValue / Double.Parse(Editor.Text));
                        break;
                    case "×":
                        lastresultValue = (resultValue * Double.Parse(Editor.Text));
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(Editor.Text);
                oprationPerformed = button.Text;
                Editor.Text = "0";
            }
            else if ((lastresultValue != 0 || lastresultValue != null))
            {
                switch (oprationPerformed)
                {
                    case "+":
                        lastresultValue = (lastresultValue + Double.Parse(Editor.Text));
                        break;
                    case "-":
                        lastresultValue = (lastresultValue - Double.Parse(Editor.Text));
                        break;
                    case "÷":
                        lastresultValue = (lastresultValue / Double.Parse(Editor.Text));
                        break;
                    case "×":
                        lastresultValue = (lastresultValue * Double.Parse(Editor.Text));
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(Editor.Text);
                oprationPerformed = button.Text;
                Editor.Text = "0";
            }

            if (button.Text == "=")
            {
                Editor.Text = lastresultValue.ToString();
                resultValue = null;
                lastresultValue = null;
                oprationPerformed = "";

            }
            else if (!(Editor.Text == "0" || Editor.Text == "" || Editor.Text == "." || Editor.Text == "0."))
            {
                oprationPerformed = button.Text;

            }

            LiveResultOprator.Text = resultValue + " " + oprationPerformed;
            LiveResult.Text = lastresultValue.ToString();
        }
        // Cleans the entry 
        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            Editor.Text = "0";
            resultValue = null;
            lastresultValue = null;
            LiveResultOprator.Text = "";
            LiveResult.Text = "";
            oprationPerformed = "";
        }
        // Cleans edit able section 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Editor.Text = "0";
        }
        // Opens About page 
        private async void BtnAbout_ClickAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutPage());
        }
    }
}
