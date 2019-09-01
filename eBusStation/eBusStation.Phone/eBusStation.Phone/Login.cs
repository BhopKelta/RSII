using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using eBusStation.PCL.Util;
using eBusStation.PCL.Model;
using Xamarin.Forms;
using Newtonsoft.Json;
using PCLAppConfig;

namespace eBusStation.Phone
{
	public class Login : ContentPage
	{
		public Login ()
		{
            StackLayout stack = new StackLayout();
            stack.VerticalOptions = LayoutOptions.CenterAndExpand;
            stack.Margin = 15;

            Label header = new Label();
            header.Text = "Prijava na sistem";
            header.FontSize = 25;
            header.HorizontalTextAlignment = TextAlignment.Center;
            stack.Children.Add(header);

            Entry textboxUsername = new Entry
            {
                Placeholder = "Unesite korisnicko ime"
            };
            Entry textBoxPassword = new Entry
            {
                Placeholder = "****",
                IsPassword = true
            };
            stack.Children.Add(textboxUsername);
            stack.Children.Add(textBoxPassword);

            Button buttonLogin = new Button();
            buttonLogin.Clicked += async (s, e) =>
            {
                IDictionary<string, string> query = new Dictionary<string, string>();
                query.Add("username", textboxUsername.Text);

                HttpResponseMessage response =  WebApiHelper.GetResult("/Login/Authenticate_Mobile_User", query);
                if (response.IsSuccessStatusCode)
                {
                    Korisnici user = JsonConvert.DeserializeObject<Korisnici>(response.Content.ReadAsStringAsync().Result);
                    if (user != null)
                    {
                        string hash = UIHelper.GenerateHash(textBoxPassword.Text, user.Salt);

                        if (hash == user.Hash)
                        {
                            App.Username = user.Ime;
                            App.RememberMe = true;
                            App.UserId = user.Id;
                            App.Job = user.Zanimanje;

                            Application.Current.MainPage = new Menu(new MainPage());
                        }
                        else
                            await DisplayAlert("Neuspjeh", "Neuspjesna prijava", "OK");
                    }
                    else
                        await DisplayAlert("Neuspjeh", "Netacni podaci", "OK");
                }
            };
            buttonLogin.Text = "Prijava";

            Button buttonRegistration = new Button();
            buttonRegistration.Clicked += async (s, e) =>
              {
                  await Navigation.PushModalAsync(new Registration());
              };
            buttonRegistration.Text = "Registracija";
            stack.Children.Add(buttonLogin);
            stack.Children.Add(buttonRegistration);

            Content = stack;
		}
	}
}