using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class AddMerchandiser : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");


        public AddMerchandiser()
        {
            InitializeComponent();
        }

         async void Button_AddMerc(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Model.Merchandiser>();

            var pKey = db.Table<Model.Merchandiser>().OrderByDescending(c => c.ID).FirstOrDefault();

            Model.Merchandiser mer = new Model.Merchandiser
            {
                ID = pKey == null ? 1 : pKey.ID + 1,
                Name = merName.Text,
                Phone = merAddress.Text,
            };

            db.Insert(mer);

            await DisplayAlert(null, mer.Name + " " + "Added", "OK");
            await Navigation.PopAsync();
        }
    }
}
