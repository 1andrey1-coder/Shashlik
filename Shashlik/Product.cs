using SQLite;

namespace Shashlik
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]//уникальный индефикатор только для id  
        public int id { get; set; } 

        public string Article { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Image {  get; set; }  
    }
}