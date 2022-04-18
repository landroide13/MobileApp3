using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MerchanServ.View
{
    public partial class MenuSuperv : ContentPage
    {
        public MenuSuperv()
        {
            InitializeComponent();
        }

        async void Button_AddMerc(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddMerchandiser());
        }

        async void Button_AddStore(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddStore());
        }

        async void Button_AddTicket(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddTicket());
        }

        async void Button_ListTicket(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListTickets());
        }

        async void Button_UpdateStore(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new UpdateStore());
        }

        async void Button_GetStore(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GetStore());
        }

        async void Button_ListMerc(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListMerc());
        }


    }
}
