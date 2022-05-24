using Dolzhenkov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dolzhenkov.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void ButtonOnOff_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entryTitle.Text))
            {
                await App.DataBase.SaveTextAsync(new Text() { Title = entryTitle.Text });
                lableResult.Text = "Текст успешно сохранён";
                lableResult.TextColor = Color.Black;
            }
            else
            {
                lableResult.TextColor = Color.Red;
                lableResult.Text = "Текст не может быть пустым!";
            }

        }
    }
}
