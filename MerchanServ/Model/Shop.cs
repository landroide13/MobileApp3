using System;
using SQLite;
namespace MerchanServ.Model
{
    public class Shop
    {
        [PrimaryKey]

        public int ID { get; set; }

        public string ShopName { get; set; }


        public Shop()
        {
        }
    }
}
