using app.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();

            BindingContext = new ListViewViewModel();
        }

       
    }
}
