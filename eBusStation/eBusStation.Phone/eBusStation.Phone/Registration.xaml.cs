using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using eBusStation.PCL.Util;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eBusStation.PCL.Model;
using System.Net.Http;

namespace eBusStation.Phone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            textBoxPassword.IsPassword = true;
            textBoxPasswordAgain.IsPassword = true;
            try
            {
                MailAddress mailToValidate = new MailAddress(textBoxEmail.Text);
            }
            catch(Exception exception)
            {
                LabelEmail.Text = "Niste unijeli ispravan email";
                LabelEmail.TextColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text))
            {
                LabelRegistration.Text = "Molimo unesite obavezne podatke";
                LabelRegistration.TextColor = Color.Red;
                return;
            }
            if(!textBoxPassword.Text.Equals(textBoxPasswordAgain.Text))
            {
                LabelPassword.Text = "Lozinke nisu iste";
                LabelPassword.TextColor = Color.Red;
                return;
            }
            Korisnici user = new Korisnici();
            user.datumRodjenja = datePicker.Date;
            user.Ime = textBoxName.Text;
            user.Prezime = textBoxSurname.Text;
            user.Spol = radioButtonGender.SelectedItem.ToString();
            user.username = textBoxUsername.Text;
            user.UlogeId = 1;
            user.Zanimanje = pickerJob.SelectedItem.ToString();
            user.Email = textBoxEmail.Text;
            user.isValid = true;
            user.Discriminator = "Klijenti";

            string salt = UIHelper.GenerateSalt();
            string hash = UIHelper.GenerateHash(textBoxPassword.Text, salt);
            user.Hash = hash;
            user.Salt = salt;

            HttpResponseMessage response = WebApiHelper.PostResult("/Login/AddUser",user);
            if (response.IsSuccessStatusCode)
            {
                DisplayAlert("Uspjeh", "Uspjesno kreiran korisnicki nalog", "OK");
                this.Navigation.PopModalAsync();
            }
        }
    }
}