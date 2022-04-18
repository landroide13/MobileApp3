using System;
using System.Collections.Generic;
using System.IO;
using SQLite;

using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class AddStore : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        public AddStore()
        {
            InitializeComponent();
        }

        async void Button_AddStore(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Model.Shop>();

            var pKey = db.Table<Model.Shop>().OrderByDescending(c => c.ID).FirstOrDefault();

            Model.Shop sto = new Model.Shop
            {
                ID = pKey == null ? 1 : pKey.ID + 1,
                ShopName = stoName.Text,
                ShopAddress = stoAddress.Text,
            };

            db.Insert(sto);

            await DisplayAlert(null, sto.ShopName + " " + "Added", "OK");
            await Navigation.PopAsync();
        }
    }
}
