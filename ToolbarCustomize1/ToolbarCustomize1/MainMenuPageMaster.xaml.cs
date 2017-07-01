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

namespace ToolbarCustomize1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPageMaster : ContentPage
    {
        public ListView ListView;

        public MainMenuPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainMenuPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainMenuPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainMenuPageMenuItem> MenuItems { get; set; }

            public MainMenuPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainMenuPageMenuItem>(new[]
                {
                    new MainMenuPageMenuItem { Id = 0, Title = "Page 1" },
                    new MainMenuPageMenuItem { Id = 1, Title = "Page 2" },
                    new MainMenuPageMenuItem { Id = 2, Title = "Page 3" },
                    new MainMenuPageMenuItem { Id = 3, Title = "Page 4" },
                    new MainMenuPageMenuItem { Id = 4, Title = "Page 5" },
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