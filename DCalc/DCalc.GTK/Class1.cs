﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace DCalc.GTK
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("DCalc");
            window.Show();

            Gtk.Application.Run();
        }
    }
}
