using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shashlik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }   

        private async void ToProduct(object sender, EventArgs e)
        {
             await Navigation.PushModalAsync(new ProductPage());   
        }
    }
}
