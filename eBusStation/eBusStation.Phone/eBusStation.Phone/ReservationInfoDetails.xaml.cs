using eBusStation.PCL.Model;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eBusStation.PCL.Util;
using System.Text.RegularExpressions;

namespace eBusStation.Phone
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReservationInfoDetails : ContentPage
	{
        private int cardId;
        private List<Discount_Line_Model> discountsOnLine { get; set; }

        public ReservationInfoDetails()
		{
            Regex allDiscountCardPrice = new Regex(@"^[Svi]$");
            Regex studentDiscount = new Regex(@"^[Studentski]$");

			InitializeComponent ();

            //Get data specific for chosen offer
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("offerId", App.OfferId.ToString());

            HttpResponseMessage response = WebApiHelper.GetResult("/Relation/GetSpecificOffer/{offerId}", query);

            //Get user credit cards
            query = new Dictionary<string, string>();
            query.Add("userId", App.UserId.ToString());
            HttpResponseMessage creditCardsResponse = WebApiHelper.GetResult("/User/GetUserCards/{userId}", query);

            //Get discounts on line
            query = new Dictionary<string, string>();
            query.Add("lineId", App.LineId.ToString());

            HttpResponseMessage discounts = WebApiHelper.GetResult("/Discount/GetDiscountsOnLine/{lineId}", query);
            if (discounts.IsSuccessStatusCode)
            {
                discountsOnLine = JsonConvert.DeserializeObject<List<Discount_Line_Model>>(discounts.Content.ReadAsStringAsync().Result);
            }

            if (response.IsSuccessStatusCode)
            {
                OfferInfo_Model offer = JsonConvert.DeserializeObject<OfferInfo_Model>(response.Content.ReadAsStringAsync().Result);
                travelRelationLabel.Text = App.OfferName;
                travelTypeOfCardLabel.Text = offer.isStudentska == true ? "Studentska" : "Obicna";
                travelDateOfTravelLabel.Text = App.DateOfTravel.ToShortDateString();

                string seats="";
                //Geenerate random seats;
                for(int i = 0; i < App.TicketNumber; i++)
                {
                    seats+=UIHelper.GenerateRandomSeats(App.BusMaxSeats);
                }
                travelNumberOfBusSeats.Text = seats;
                travelTicketNumber.Text = App.TicketNumber.ToString();

                float price = 0;
                if(App.TravelingFromBeginningStation)
                {
                    price =(float) (App.TicketNumber * offer.cijenaOdPolaska);
                }
                else
                {
                    price = (float)App.TicketNumber * (float)offer.CijenaOdTrenutnogGradaDoDestinacije;
                }
                //Two way ticket.
                if (App.TwoWayTicket)
                {
                    price += price / 2;
                    twoWayTicketLabel.IsVisible = true;
                }
                //Calculate discount price if exits.
                foreach (var item in discountsOnLine)
                {
                    if (item.vrstaPopusta.Equals("Svi"))
                    {
                        price -= price / (100 / item.Postotak);
                        DisplayAlert("Info o popustu", "Na ovoj liniji postoji popust za sve putnike, koji je jos validan od " + item.Postotak + "%", "OK");
                    }
                    else if (item.vrstaPopusta=="Studentski")
                    {
                        if (App.CardType == "Studentska")
                        {
                            price -= price / (100 / item.Postotak);
                            DisplayAlert("Info o popustu", "Na ovoj liniji postoji popust za studente, koji je jos validan od " + item.Postotak + "%", "OK");
                        }
                    }
                }
                travelPriceToPay.Text = price.ToString()+"KM";
                App.TotalPrice = price;
            }
            if (creditCardsResponse.IsSuccessStatusCode)
            {
                List<User_Credit_Cards_Model> cards = JsonConvert.DeserializeObject<List<User_Credit_Cards_Model>>(creditCardsResponse.Content.ReadAsStringAsync().Result);
                travelCreditCards.ItemsSource = cards;
                travelCreditCards.ItemDisplayBinding = new Binding("Kartica");
            }
        }

        //Add transaction in db.
        private void ButtonSave_Clicked(object sender, EventArgs e)
        {
            User_Credit_Cards_Model selectedCreditCard = travelCreditCards.SelectedItem as User_Credit_Cards_Model;

            if (selectedCreditCard == null)
            {
                DisplayAlert("Neuspjeh", "Molimo odaberite jedni od kartica", "OK");
                return;
            }

            Transaction_Model transaction = new Transaction_Model
            {
                brojTransakcije = "xxx",
                datumKupovine = DateTime.Now,
                KarticaId = selectedCreditCard.Id,
                KlijentiId = App.UserId,
                Status = "A",
                otkazano = false
            };
            HttpResponseMessage transactionResponse = WebApiHelper.PostResult("/Transaction/AddNewTransaction", transaction);
            decimal? transactionId = 0;
            if (transactionResponse.IsSuccessStatusCode)
            {
                transactionId = JsonConvert.DeserializeObject<decimal?>(transactionResponse.Content.ReadAsStringAsync().Result);
            }
            for(int i = 0; i < App.TicketNumber;i++)
            {
                Ticket_Model ticket = new Ticket_Model();
                ticket.Aktivna = true;
                ticket.BrojKarte = "xxx" + travelNumberOfBusSeats.Text;
                ticket.brojSjedista = travelNumberOfBusSeats.Text;
                ticket.datumPutovanja = App.DateOfTravel;
                ticket.PosjecujeLokacijeId = App.OfferId;
                ticket.TipKarteId = travelTypeOfCardLabel.Text == "Obicna" ? 1 : 2;

                HttpResponseMessage response = WebApiHelper.PostResult("/BusCard/AddCard", ticket);
                if (response.IsSuccessStatusCode)
                {
                    decimal? busCardId = JsonConvert.DeserializeObject<decimal?>(response.Content.ReadAsStringAsync().Result);

                    if (busCardId.HasValue && transactionId.HasValue)
                    {
                        Transaction_Detail_Model details = new Transaction_Detail_Model
                        {
                            TransakcijaId = (int)transactionId,
                            KartaId = (int)busCardId,
                            Kolicina = Convert.ToInt32(App.TicketNumber),
                            UkupnaCijena = App.TotalPrice
                        };
                        HttpResponseMessage transactionDetailsResponse = WebApiHelper.PostResult("/Transaction/AddTransactionDetails", details);
                    }
                    DisplayAlert("Uspjeh", "Uspjesno ste izvrsili rezervaciju karte", "OK");
                    this.Navigation.PushModalAsync(new Menu(new Transaction()));
                }
            }
        }
    }
}