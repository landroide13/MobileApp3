using System;
using SQLite;

namespace MerchanServ.Model
{
    public class Ticket
    {
        [PrimaryKey]
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int Time { get; set; }

        public string Comment { get; set; }

        public String Status { get; set; }

        public Ticket()
        {
        }
    }
}
