using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBusStation.Phone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMaster : ContentPage
    {
        public ListView ListView { get; set; }
        public MenuMaster()
        {
            InitializeComponent();
            BindingContext = new MenuMasterViewModel();

            var context = (MenuMasterViewModel)BindingContext;
            listViewMenu.ItemsSource = context.MenuItems;

            ListView = listViewMenu;
        }

        class MenuMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuMenuItem> MenuItems { get; set; }

            public MenuMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuMenuItem>(new[]
                {
                   new MenuMenuItem{ Id = 0, Title = "Pocetna", IconSource = "home.png", TargetType = typeof(MainPage) },
                   new MenuMenuItem { Id = 1, Title = "Pretrazivanje", IconSource = "search.png", TargetType = typeof(Search) },
                   new MenuMenuItem { Id = 2, Title = "Rezervacije", IconSource = "transaction.png", TargetType = typeof(Transaction) },
                   new MenuMenuItem { Id = 3, Title = "Recenzija/putovanja", IconSource = "flag.png", TargetType = typeof(Travel_Recension) }

            });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}