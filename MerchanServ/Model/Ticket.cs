using System;
using SQLite;

namespace MerchanServ.Model
{
    public class Ticket
    {
        [PrimaryKey]
        public int ID { get; set; }

        public string TicName { get; set; }

        public DateTime TicDate { get; set; }

        public int Time { get; set; }

        public string TicAddress { get; set; }

        public string TicComment { get; set; }

        public String TicStatus { get; set; }

        public Ticket()
        {
        }

    }
}
