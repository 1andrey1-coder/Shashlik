using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shashlik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();

        }
        private void product(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.AddRange(products);    

        }

        private async void AddProductClicked(object sender, EventArgs e)
        {
            //Trim - обрезает поле от лишних пробелов
            string name = NameField.Text.Trim();
            string image = ImageField.Text.Trim();
            string article = ArticleField.Text.Trim();
            string title = TitleField.Text.Trim();
            string category = CategoryField.Text.Trim();
            int weight = Convert.ToInt32(WeightField.Text.Trim());
            if (name.Length < 5)
            {
                await DisplayAlert("Ошибка", "Name min 5", "OK");
            }
            else if (image == null )
            {

            }
            else if (article.Length < 5)
            {
                await DisplayAlert("Ошибка", "Article min 5", "OK");
            }
            else if (title.Length < 5)
            {
                await DisplayAlert("Ошибка", "Title min 5", "OK");
            }
            else if (category.Length < 10)
            {
                await DisplayAlert("Ошибка", "Category min 10", "OK");
            }
            else if (weight < 7)
            {
                await DisplayAlert("Ошибка", "Weight min 7", "OK");
            }


            Product product = new Product()//все данные и значения аксеса
            {
                Name = name,//то что получаем от пользователя
                Image = image,
                Article = article,
                Title = title,
                Category = category,
                Weight = weight,
            };
            App.Db.SaveProduct(product);//сохранение в бд

            //Очистка после добавления
            NameField.Text = "";
            ImageField.Text = "";
            ArticleField.Text = "";
            TitleField.Text = "";
            CategoryField.Text = "";
            WeightField.Text = "";
        }

        private async void Nazad(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());  
        }
        

    }
}