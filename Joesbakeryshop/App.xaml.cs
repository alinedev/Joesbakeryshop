using Joesbakeryshop.pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Joesbakeryshop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new HomePage());
            // MainPage = new NavigationPage (new LoginPage());
            //MainPage = new NavigationPage(new SignupPage());
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
