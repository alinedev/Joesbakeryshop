using Joesbakeryshop.Models;
using Joesbakeryshop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Joesbakeryshop.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        private async void BtnBookTable_OnClicked(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation()
            {
                Name = EntName.Text,
                Email = EntEmail.Text,
                Phone = EntPhone.Text,
                TotalPeople = EntTotalPeople.Text,
                Date = TpBookingDate.Date.ToString(),
                Time = TpBookingTime.Time.ToString(),
            };
            ApiServices apiServices = new ApiServices();
            bool response = await apiServices.ReserveTable(reservation);
            if(response != true)
            {
                await DisplayAlert("oops","soething is bad","alright");
            }
            else
            {
                await DisplayAlert("Thanks for choosing Joesbakeryshop","Your Reservation has benn received","See you Later");
            }
        }
    }
}