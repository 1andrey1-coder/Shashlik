using SQLite;

namespace Shashlik
{
     public class Product
    {
        [PrimaryKey, AutoIncrement]//уникальный индефикатор только для id  
        public int Id { get; set; } 
        public string Article { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Image {  get; set; }  
    }
}