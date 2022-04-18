using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class AddTicket : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        public AddTicket()
        {
            InitializeComponent();
        }

        async void Button_AddTic(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Model.Ticket>();

            var pKey = db.Table<Model.Ticket>().OrderByDescending(t => t.ID).FirstOrDefault();

            Model.Ticket tic = new Model.Ticket
            {
                ID = pKey == null ? 1 : pKey.ID + 1,
                TicName = ticName.Text,
                TicAddress = ticAddress.Text,
                TicDate = ticDate.Date
            };

            db.Insert(tic);

            await DisplayAlert(null, tic.TicName + " " + "Added", "OK");
            await Navigation.PopAsync();
        }


    }
}
