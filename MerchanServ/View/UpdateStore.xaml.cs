using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class UpdateStore : ContentPage
    {
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "MerchanServDB.db3");

        Model.Shop sto = new Model.Shop();

        public UpdateStore()
        {
            InitializeComponent();

            var db = new SQLiteConnection(dbPath);

            listStore.ItemsSource = db.Table<Model.Shop>().OrderBy(c => c.ShopName).ToList();

            listStore.ItemSelected += Listview_ItemSelected;
        }


        private void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            sto = (Model.Shop)e.SelectedItem;
            stoID.Text = sto.ID.ToString();
            stoName.Text = sto.ShopName;
            stoAddress.Text = sto.ShopAddress;

        }


        async void Button_Update(System.Object sender, System.EventArgs e)
        {
            var db = new SQLiteConnection(dbPath);

            Model.Shop sto = new Model.Shop
            {
                ID = Convert.ToInt32(stoID.Text),
                ShopName = stoName.Text,
                ShopAddress = stoAddress.Text,
            };

            db.Update(sto);

            await DisplayAlert(null, sto.ShopName + " " + "Updated", "OK");
            await Navigation.PopAsync();

        }



    }
}
