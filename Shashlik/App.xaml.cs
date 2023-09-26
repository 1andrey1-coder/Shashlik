using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
namespace Shashlik
{
    public partial class App : Application
    {

        private static DB db;//создание некоторого поля
        public static DB Db//аксесер
        {
            get
            {
                if (db == null)
                    db = new DB(Path.Combine(Environment.GetFolderPath(Environment
                        .SpecialFolder.LocalApplicationData),"db.sqlite3"));
                        return db;//выделить память для подключения, а если память
                                  //не надо выделять мы и так выдадим готовое подключение
                //Combine - это обьединить несколько значений в один общий путь
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
