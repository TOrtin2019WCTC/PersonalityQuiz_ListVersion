using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Personality_Quiz_list
{
    public partial class Results : ContentPage
    {
        public Results()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(false);
        }
    }
}
