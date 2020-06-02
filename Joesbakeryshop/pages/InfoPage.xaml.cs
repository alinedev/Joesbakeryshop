using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Joesbakeryshop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void TapFacebook_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/JoesBakery-Shop-102042538208757"));
        }

        private void TapYoutube_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com"));
        }

        private void TapTwitter_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.twitter.com"));
        }

        private void TapInstagram_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.instagram.com"));
        }

        private void TapCall_Tapped(object sender, EventArgs e)
        {
            PhoneDialer.Open("2393626609");
        }
    }
}