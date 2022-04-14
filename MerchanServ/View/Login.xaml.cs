using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Button_super(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MenuSuperv());
        }

        async void Button_merch(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MenuMerch());
        }
    }
}
