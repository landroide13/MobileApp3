using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class MenuMerch : ContentPage
    {

        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        Model.Ticket tic = new Model.Ticket();

        public MenuMerch()
        {
            InitializeComponent();

            var db = new SQLiteConnection(dbPath);

            listTickets.ItemsSource = db.Table<Model.Ticket>().OrderBy(t => t.TicDate).ToList();

            listTickets.ItemSelected += Listview_ItemSelected;
        }


        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            tic = (Model.Ticket)e.SelectedItem;
           
        }

    }
}
