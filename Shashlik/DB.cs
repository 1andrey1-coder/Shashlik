using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shashlik
{

    public class DB
    {
        private readonly SQLiteConnection conn;

        //конструктор
        //Путь куда будет все сохраняться(в path)
        public DB(string path)
        {
            conn = new SQLiteConnection(path);//выделение памяти
            conn.CreateTable<Product>();//таблица где все записывается
        }
        //Path-(параметрр)где будет храниться и создаваться файл

        //Получаем все записи
        public List<Product> GetProducts()
        {
            return conn.Table<Product>().ToList();//получаем все записи из Product и преобразуем к списку
        }

        public int SaveProduct(Product product)
        {
            return conn.Insert(product);//добавляем в бд и сохраняем
        }
       public int DeleteProduct(int id)
        {
            DeleteProduct(id);
            return conn.Delete(id); 
        }

    }
}
