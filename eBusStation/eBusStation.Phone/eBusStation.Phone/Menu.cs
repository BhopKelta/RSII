using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eBusStation.Phone
{
    public class Menu:MasterDetailPage
    {
       private  MenuMaster masterPage;
        public Menu()
        {
            masterPage = new MenuMaster();
            Detail = new NavigationPage(new Login());
            masterPage.ListView.ItemSelected += OnItemSelected;
            Master = masterPage;
        }
        public Menu(Page page)
        {
            masterPage = new MenuMaster();
            Detail = new NavigationPage(page);
            masterPage.ListView.ItemSelected += OnItemSelected;
            Master = masterPage;
        }
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MenuMenuItem item = e.SelectedItem as MenuMenuItem;
            if (item != null && !string.IsNullOrEmpty(App.Username))
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
            else if(string.IsNullOrEmpty(App.Username))
            {
                DisplayAlert("Neuspjeh","Morate se prijaviti","OK");
            }
        }
    }
}
