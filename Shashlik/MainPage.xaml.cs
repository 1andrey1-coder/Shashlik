using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;


namespace Shashlik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ShowProducts();
        }

        private void ShowProducts()//Отображать все записи из конкретной коллекции
        {
            ProductList.ItemsSource = App.Db.GetProducts();
        }

        private async void ToProduct(object sender, EventArgs e)
        {
             await Navigation.PushModalAsync(new ProductPage());//переход по кнопке навигация
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Product selectedFriend = (Product)e.SelectedItem;
            ProductPage friendPage = new ProductPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushModalAsync(friendPage);
        }
    }
}
