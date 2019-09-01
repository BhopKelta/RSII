using eBusStation.PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using eBusStation.PCL.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace eBusStation.Phone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryBeginningStation.Text) && string.IsNullOrEmpty(entryEndingStation.Text)
                && string.IsNullOrEmpty(entryTraveler.Text) && string.IsNullOrEmpty(entryTimeStarting.Text)
                            && string.IsNullOrEmpty(entryTimeOfComingAtStation.Text))
            {
                DisplayAlert("Neuspjeh", "Ne smije biti sva polja prazna", "OK");
                return;
            }
            var regex = new Regex(@"^\d{2}[:.,-\\s]?\d{2}$");
            var regexForNumbers = new Regex(@"^\d+$");
            var regexForText = new Regex(@"^[a-zA-Z]+$");

            //Check for numbers in string(start,destination,traveler)
            if (string.IsNullOrEmpty(entryBeginningStation.Text) == false || string.IsNullOrEmpty(entryEndingStation.Text) == false 
                || string.IsNullOrEmpty(entryTraveler.Text) == false)
            {
                //Get not null string 
                string notNulText = string.IsNullOrEmpty(entryBeginningStation.Text) == false ? entryBeginningStation.Text : entryEndingStation.Text;
                if (string.IsNullOrEmpty(notNulText))
                    notNulText = entryTraveler.Text;

                if (regexForNumbers.IsMatch(notNulText))
                {
                    DisplayAlert("Neuspjeh", "Ovdje biste trebali unijeti samo slova a ne brojeve", "OK");
                    return;
                }
            }
            //Check for string in number field(time of Start ,timeOfComing)
            if (string.IsNullOrEmpty(entryTimeStarting.Text) == false || string.IsNullOrEmpty(entryTimeOfComingAtStation.Text) == false)
            {
                string notNullText = string.IsNullOrEmpty(entryTimeStarting.Text) == false ? entryTimeStarting.Text : entryTimeOfComingAtStation.Text;

                if (regexForText.IsMatch(notNullText))
                {
                    DisplayAlert("Neuspjeh", "Ovdje biste trebali unijeti samo brojeve a ne slova", "OK");
                    return;
                }
            }

            if (!string.IsNullOrEmpty(entryTimeStarting.Text))
            {
                if (regex.IsMatch(entryTimeStarting.Text))
                {
                    //Find matches of numbers in string
                    if (entryTimeStarting.Text.Contains(" "))
                        entryTimeStarting.Text = entryTimeStarting.Text.Replace(' ', ':');
                    else if (entryTimeStarting.Text.Contains("."))
                        entryTimeStarting.Text = entryTimeStarting.Text.Replace('.', ':');
                    else if (entryTimeStarting.Text.Contains("-"))
                        entryTimeStarting.Text = entryTimeStarting.Text.Replace('-', ':');
                }
            }
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("start", entryBeginningStation.Text);
            query.Add("end", entryEndingStation.Text);
            query.Add("traveler", entryTraveler.Text);
            query.Add("startTime", entryTimeStarting.Text);
            query.Add("endTime", entryTimeOfComingAtStation.Text);

            HttpResponseMessage response = WebApiHelper.GetResult("/Relation/SearchLines",query);
            if (response.IsSuccessStatusCode)
            {
                List<Lines_Search_Model> searchResult = JsonConvert.DeserializeObject<List<Lines_Search_Model>>(response.Content.ReadAsStringAsync().Result);
                searchListView.ItemsSource = searchResult;
                searchListView.ItemSelected += OnItemSelected;
            }
        }
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Lines_Search_Model;

            StringBuilder builder = new StringBuilder();
            builder.Append("Posjeceni grad linija prolazi kroz->"+ item.PosjeceniGrad+"\n");
            if (item.cijenaOdPolaska != 0)
                builder.Append("Cijena od polazne stanice-trenutnog grada :" + item.cijenaOdPolaska + "KM" + "\n");
            else
                builder.Append("Cijena od trenutne stanice-destinacije:" + item.CijenaOdTrenutnogGradaDoDestinacije + "KM" + "\n");


            if (item.isStudentska.HasValue)
            {
                if ((bool)item.isStudentska)
                    builder.Append("Tip karte:" + "Studentska");
                else
                    builder.Append("Tip karte:" + "Obicna");
                DisplayAlert("Detalji ponude", builder.ToString(), "OK");
            }
        }
    }
}