using System;
using SQLite;

namespace MerchanServ.Model
{
    public class Merchandiser
    {
        [PrimaryKey]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public Merchandiser()
        {
        }
    }
}
