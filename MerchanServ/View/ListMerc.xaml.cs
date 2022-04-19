using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class ListMerc : ContentPage
    {
         string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        public ListMerc()
        {
            InitializeComponent();

             var db = new SQLiteConnection(dbPath);

            if(db.Table<Model.Merchandiser>() == null)
            {
                _ = DisplayAlert(null, "Database empty", "Ok");
            }
            else
            {
               listMercs.ItemsSource = db.Table<Model.Merchandiser>().OrderBy(m => m.Name).ToList();
            }
        }
    }
}
