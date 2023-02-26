using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio1_lab_rad
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageAlums());
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
