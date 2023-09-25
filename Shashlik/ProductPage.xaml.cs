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

        private async void Nazad(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());  
        }

        
    }
}