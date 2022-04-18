using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class ListTickets : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        Model.Ticket tic = new Model.Ticket();

        public ListTickets()
        {
            InitializeComponent();

            var db = new SQLiteConnection(dbPath);

            listTickets.ItemsSource = db.Table<Model.Ticket>().OrderBy(t => t.TicDate).ToList();

            listTickets.ItemSelected += Listview_ItemSelected;
        }

        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            tic = (Model.Ticket)e.SelectedItem;
            ticID.Text = tic.ID.ToString();
            ticName.Text = tic.TicName;
            ticAddress.Text = tic.TicAddress;
            ticDate.Date = tic.TicDate;
        }

        async void Button_Update(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            Model.Ticket tic = new Model.Ticket
            {
                ID = Convert.ToInt32(ticID.Text),
                TicName = ticName.Text,
                TicAddress = ticAddress.Text,
                TicDate = ticDate.Date
        };

            db.Update(tic);

            await DisplayAlert(null, tic.TicName + " " + "Updated", "OK");
            await Navigation.PopAsync();

        }


    }
}
