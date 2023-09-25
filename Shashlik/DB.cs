using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shashlik
{

    public class DB
    {
        private readonly SQLiteConnection conn;


        public DB(string path)
        {
            conn = new SQLiteConnection(path); 
            conn.CreateTable<Product>();
        }

        public List<Product> GetProducts()
        {
            return conn.Table<Product>().ToList();
        }

        public int SaveProduct(Product product)
        {
            return conn.Insert(product);
        }

    }
}
