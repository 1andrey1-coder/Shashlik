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
            string weight = WeightField.Text.Trim();
            //провекра
            if (name.Length < 2)
            {
                await DisplayAlert("Ошибка", "Name min 2", "OK");
            }
            else if (image == null )
            {

            }
            else if (article.Length < 2)
            {
                await DisplayAlert("Ошибка", "Article min 2", "OK");
            }
            else if (title.Length < 2)
            {
                await DisplayAlert("Ошибка", "Title min 2", "OK");
            }
            else if (category.Length < 2)
            {
                await DisplayAlert("Ошибка", "Category min 2", "OK");
            }
            else if (weight.Length < 1)
            {
                await DisplayAlert("Ошибка", "Weight min 1", "OK");
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
            //WeightField.Text = "";
        }

        private async void Nazad(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new MainPage());
        }

        private void DeleteFriend(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            App.Db.DeleteProduct2(product.id);
            this.Navigation.PopModalAsync();
        }


        private void SaveFriend(object sender, EventArgs e)
        {
            var product = (Product)BindingContext;
            if (!String.IsNullOrEmpty(product.Name))
            {
                App.Db.SaveProduct(product);
            }
            this.Navigation.PopModalAsync();

        }
    }
}