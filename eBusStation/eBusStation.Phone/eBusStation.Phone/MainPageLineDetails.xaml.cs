using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBusStation.PCL.Util;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eBusStation.PCL.Model;
using System.Net.Http;
using Newtonsoft.Json;

namespace eBusStation.Phone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageLineDetails : ContentPage
    {
        private ListView recommender { get; set; }
        private List<Cities_Passing_Line_Model> model;
        public MainPageLineDetails(int id = 0)
        {
            InitializeComponent();
            model = new List<Cities_Passing_Line_Model>();
            App.LineId = id;
            
            //Get data.
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("lineId", id.ToString());
            HttpResponseMessage responseCities = WebApiHelper.GetResult("/Relation/lineId/Cities", query);

            model = JsonConvert.DeserializeObject<List<Cities_Passing_Line_Model>>(responseCities.Content.ReadAsStringAsync().Result);

            listDetailCities.ItemsSource = model;
            listDetailCities.ItemSelected += OnItemSelected;
        }
        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            IDictionary<string, string> query = new Dictionary<string, string>();

            Cities_Passing_Line_Model item = e.SelectedItem as Cities_Passing_Line_Model;
            int occurrenceOfHyphen = item.Naziv.IndexOf('-');
            query.Add("relationId", item.Id.ToString());

            if (App.Job != "Student" && !string.IsNullOrEmpty(App.Job))
            {
                if (item.Tip_karte == "Studentska")
                {
                    await DisplayAlert("Neuspjeh", "Malo smo bezobranzni mozda, studentska a niste student", "OK");
                    return;
                }
            }
            string oneOrTwoWayTicket = App.TwoWayTicket ? "Povratna" : "Jedansmjer";

            //Show reservation form, to check available places in bus.
            await Navigation.PushModalAsync(new Reservation(App.LineId));
            if (item.Cijena_od_grada_destinacije == 0)
            {
                await DisplayAlert("Vasa ponuda:" + item.Naziv.Substring(0, occurrenceOfHyphen) + "-" + item.Grad, "Odabrali ste ponudu na liniji "
                      + item.Naziv + "\n" + "Tip karte:" + item.Tip_karte + "\n" + "Vasa karta:" + oneOrTwoWayTicket, "OK");
                App.TravelingFromBeginningStation = true;
                App.OfferName = item.Naziv.Substring(0, occurrenceOfHyphen) + "-" + item.Grad;
            }

            else
            {
                await DisplayAlert("Vasa ponuda:" + item.Grad + "-" + item.Naziv.Substring(occurrenceOfHyphen + 1,
                      item.Naziv.Length - occurrenceOfHyphen - 1), "Ponuda na liniji :" + item.Naziv
                      + "\n" + "Tip karte:" + item.Tip_karte + "\n" + "Vasa karta:" + oneOrTwoWayTicket, "OK");
                App.TravelingFromBeginningStation = false;
                App.OfferName = item.Grad + "-" + item.Naziv.Substring(occurrenceOfHyphen + 1,
                      item.Naziv.Length - occurrenceOfHyphen - 1);
            }
            App.OfferId = item.Id;
        }

        private void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            App.TwoWayTicket = twoWayTicket.IsChecked;
            App.Recommender = recommenderBox.IsChecked;

            //Get recommended relations
            if (App.Recommender)
            {
                IDictionary<string, string> query = new Dictionary<string, string>();
                query.Add("relationId", App.LineId.ToString());

                HttpResponseMessage responseRecommender = WebApiHelper.GetResult("/Relation/RecommendRelations/{relationId}", query);
                if (responseRecommender.IsSuccessStatusCode)
                {
                    listRecommender.ItemsSource = JsonConvert.DeserializeObject<List<Cities_Passing_Line_Model>>(responseRecommender
                        .Content.ReadAsStringAsync().Result);
                }
            }
        }
    }
}