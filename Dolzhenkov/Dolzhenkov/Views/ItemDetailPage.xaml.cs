using Dolzhenkov.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Dolzhenkov.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}