using System;
using SQLite;

namespace MerchanServ.Model
{
    public class Ticket
    {
        [PrimaryKey]
        public int ID { get; set; }

        public int time { get; set; }

        public Ticket()
        {
        }
    }
}
