using eBusStation.PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eBusStation.PCL.Model;
using System.IO;
using System.Text.RegularExpressions;

namespace eBusStation.Phone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservation : ContentPage
    {
        public Reservation(int lineId = 0)
        {
            InitializeComponent();
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("lineId", lineId.ToString());

            HttpResponseMessage response = WebApiHelper.GetResult("/Bus/{lineId}/GetBus", query);
            if (response.IsSuccessStatusCode)
            {
                //Load bus picture.
                List<AutoBus_On_Line_Model> model = JsonConvert.DeserializeObject<List<AutoBus_On_Line_Model>>(response.Content.ReadAsStringAsync().Result);
                if (model.Any())
                {
                    if (model[0].slikaAutobusa != null)
                    {
                        Stream stream = new MemoryStream(model[0].slikaAutobusa);
                        imageBus.Source = ImageSource.FromStream(() => stream);
                    }
                    App.BusMaxSeats = model[0].brojSjedistaBusa;
                    entirePlacesBus.Text = "Broj sjedista u busu: " + model[0].brojSjedistaBusa;
                }
            }
        }

        //Check available places in bus
        private void Button_Clicked(object sender, EventArgs e)
        {
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("date", dateTimePickerReservation.Date.ToString("MM/dd/yyyy"));
            HttpResponseMessage response = WebApiHelper.GetResult("/Relation/GetAvailablePlacesAtDate", query);

            if (response.IsSuccessStatusCode)
            {
                List<Autobus_Available_Places_Model> model = JsonConvert.DeserializeObject<List<Autobus_Available_Places_Model>>(response.Content.ReadAsStringAsync().Result);
                occupiedPlaces.Text = "Zauzeto: " + model.Count;

                //Calculatoe availble places in bus.
                int available = 0;
                int number = UIHelper.GetNumberFromString(entirePlacesBus.Text);
                available = number - model.Count;

                //Regulate if bus cannot take anymore reservations.
                if (number == model.Count)
                {
                    DisplayAlert("Neuspjeh", "Sva mjesta su popunjena, prebacivamo vas na iduci dan rezervaciju", "OK");
                    dateTimePickerReservation.Date.AddDays(1);
                    Button_Clicked(sender, e);
                }

                //Show button for payment.
                checkAvailablePlacesButton.Opacity = 0;
                goToPaymentButton.Opacity = 1;

                goToPaymentButton.Clicked += GoToPayment;
                goToPaymentButton.Text = "Nastavi sa placanjem i pregled podataka o rezervaciji";
                availablePlaces.Text = "Slobodno: " + available;

                App.TicketNumber = numberOfTickets.Value;
                App.DateOfTravel = dateTimePickerReservation.Date;
            }
        }
        private void GoToPayment(object sender, EventArgs e)
        {
            //Show reservation info.
             this.Navigation.PushModalAsync(new Menu(new ReservationInfoDetails()));
        }
    }
}