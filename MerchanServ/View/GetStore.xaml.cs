using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class GetStore : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        public GetStore()
        {
            InitializeComponent();

            var db = new SQLiteConnection(dbPath);

            if(db.Table<Model.Shop>() == null)
            {
                _ = DisplayAlert(null, "Database empty", "Ok");
            }
            else
            {
               listSto.ItemsSource = db.Table<Model.Shop>().OrderBy(c => c.ShopName).ToList();
            }

            
        }


    }
}
