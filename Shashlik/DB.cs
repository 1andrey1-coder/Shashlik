using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shashlik
{

    public class DB
    {
        SQLiteConnection conn;

        //конструктор
        //Путь куда будет все сохраняться(в path)
        public DB(string path)
        {
            conn = new SQLiteConnection(path);//выделение памяти
            conn.CreateTable<Product>();//таблица где все записывается
        }
        //Path-(параметрр)где будет храниться и создаваться файл

        //Получаем все записи
        public IEnumerable<Product> GetProducts()
        {
            return conn.Table<Product>().ToList();//получаем все записи из Product и преобразуем к списку
        }

        public Product GetProduct(int product)
        {
            return conn.Get<Product>(product);
        }

        public int DeleteProduct2(int id)
        {
            return conn.Delete<Product>(id);

        }

        public int SaveProduct(Product product)
        {
            //добавляем в бд и сохраняем
            if (product.id != 0)
            {
                conn.Update(product);
                return product.id;
            }
            else
            {
                return conn.Insert(product);
            }
        }
       

      
    }
}
