using eBusStation.PCL.Model;
using eBusStation.PCL.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBusStation.Phone
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Travel_Recension : ContentPage
	{
        private string ratingStringValue;
        private decimal ratingValue;
		public Travel_Recension ()
		{
            InitializeComponent();
            //Get user transactions finished travels.
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("userId", App.UserId.ToString());

            HttpResponseMessage response = WebApiHelper.GetResult("/Transaction/{userId}/FinishedTransactions", query);
            if (response.IsSuccessStatusCode)
            {
                List<User_Transactions_Model> model = JsonConvert.DeserializeObject<List<User_Transactions_Model>>(response.Content.ReadAsStringAsync().Result);
                listViewTransactions.ItemsSource = model;
            }
        }
        private void Button_Recension_Make_Clicked(object sender, EventArgs e)
        {
            Button send = sender as Button;
            User_Transactions_Model selectedItem = send.CommandParameter as User_Transactions_Model;

            Recension_Model recension = new Recension_Model
            {
                KartaId = selectedItem.KartaId,
                KlijentiId = App.UserId,
                Komentar = ratingString.Text,
                Ocjena = ratingValueInt.Value
            };
            HttpResponseMessage response = WebApiHelper.PostResult("/Recension/AddRecension", recension);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Uspjeh", "Uspjesno ostavljena ocjena na putovanju", "OK");
            }
            else
            {
                DisplayAlert("Neuspjeh", "Vec postoji recenzija na putovanju", "OK");
            }
        }
    }
}