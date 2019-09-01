using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using eBusStation.PCL;
using eBusStation.PCL.Model;
using System.Net.Http;
using eBusStation.PCL.Util;
using Newtonsoft.Json;
using Mapsui.Utilities;
using Mapsui.Styles;
using Mapsui.Layers;
using Mapsui.Geometries;
using Mapsui.Providers;
using System.Diagnostics;
using Mapsui.Projection;
using System.Reflection;
using BruTile.Web;
using BruTile.Predefined;
using BruTile;

namespace eBusStation.Phone
{
    public partial class MainPage : ContentPage
    {
        private const string InfoLayerName = "Info Layer";
        private const string PolygonLayerName = "Polygon Layer";
        private const string LineLayerName = "Line Layer";
        public string Name => "2 Map Info";
        public string Category => "Demo";
        List<Lines_With_Traveler_Model> model;
        public MainPage()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(App.Username))
            {
                this.Navigation.PopAsync();
            }
            logo.Source = ImageSource.FromFile("bus.png");
            model = new List<Lines_With_Traveler_Model>();

            HttpResponseMessage responseLines = WebApiHelper.GetResult("/Relation/RelationWithTraveler");
            model = JsonConvert.DeserializeObject<List<Lines_With_Traveler_Model>>(responseLines.Content.ReadAsStringAsync().Result);
            listLines.ItemsSource = model;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Lines_With_Traveler_Model selectedItem = button.CommandParameter as Lines_With_Traveler_Model;

            MainPageLineDetails details = new MainPageLineDetails(selectedItem.Id);
            this.Navigation.PushModalAsync(details);
        }
    }
}
