using PCLAppConfig;
using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace eBusStation.Phone
{
    public partial class App : Application
    {
        public static string Username { get; set; }
        public static int UserId { get; set; }
        public static bool RememberMe { get; set; }
        public static int LineId { get; set; }
        public static bool TwoWayTicket { get; set; }
        public static bool Recommender { get; set; }
        public static int OfferId { get; set; }
        public static string OfferName { get; set; }
        public static string CardType { get; set; }
        public static double TicketNumber { get; set; }
        public static int BusMaxSeats { get; set; }
        public static DateTime DateOfTravel { get; set; }
        public static bool TravelingFromBeginningStation { get; set; }
        public static float TotalPrice { get; set; }
        public static string Job { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new Menu();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
