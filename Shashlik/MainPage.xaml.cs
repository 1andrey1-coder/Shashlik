using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void ShowProducts()
        {
            productsCollection.ItemsSource = App.Db.GetProducts();
        }

        private async void ToProduct(object sender, EventArgs e)
        {
             await Navigation.PushModalAsync(new ProductPage());   
        }

        private async void AddProductClicked(object sender, EventArgs e)
        {
            string name = NameField.Text.Trim();
            string article = ArticleField.Text.Trim();
            string title = TitleField.Text.Trim();
            string category = CategoryField.Text.Trim();
            int weight = Convert.ToInt32(WeightField.Text.Trim());
            if (name.Length < 5)
            {
                await DisplayAlert("Ошибка", "Name min 5", "OK");
            }
            else if (article.Length < 5)
            {
                await DisplayAlert("Ошибка", "Name min 5", "OK");
            }
            else if (title.Length < 25)
            {
                await DisplayAlert("Ошибка", "Name min 5", "OK");
            }
            else if (category.Length < 5)
            {
                await DisplayAlert("Ошибка", "Name min 5", "OK");
            }
            else if (weight < 5)
            {
                await DisplayAlert("Ошибка", "Name min 5", "OK");
            }


            Product product = new Product()
            {
                Name = name,
                Article = article,
                Title = title,
                Category = category,
                Weight = weight,
            };
            App.Db.SaveProduct(product);
            ShowProducts();
            NameField.Text = "";
            ArticleField.Text = "";
            TitleField.Text = "";
            CategoryField.Text = "";
            WeightField.Text = "";
        }
    }
}
