using eBusStation.PCL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eBusStation.PCL.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace eBusStation.Phone
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Transaction : ContentPage
	{
		public Transaction ()
		{
			InitializeComponent ();

            //Get user transactions
            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("userId", App.UserId.ToString());

            HttpResponseMessage response = WebApiHelper.GetResult("/Transaction/{userId}/Transactions", query);
            if (response.IsSuccessStatusCode)
            {
               List<User_Transactions_Model>model =  JsonConvert.DeserializeObject<List<User_Transactions_Model>>(response.Content.ReadAsStringAsync().Result);
                listViewTransactions.ItemsSource = model;
            }
		}
        private void Button_Cancel_Transaction_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            User_Transactions_Model selectedItem = button.CommandParameter as User_Transactions_Model;

            IDictionary<string, string> query = new Dictionary<string, string>();
            query.Add("transactionId", selectedItem.Id.ToString());

            HttpResponseMessage cancelResponsse = WebApiHelper.GetResult("/Transaction/{transactionId}/Cancel", query);
            if (cancelResponsse.IsSuccessStatusCode)
            {
                DisplayAlert("Uspjeh", "Uspjesno ste otkazali rezervacijue", "OK");
            }
        }
    }
}