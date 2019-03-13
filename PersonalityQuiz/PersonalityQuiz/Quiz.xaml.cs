using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public partial class Quiz : ContentPage
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
