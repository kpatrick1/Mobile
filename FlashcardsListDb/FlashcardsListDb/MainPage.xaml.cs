using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FlashcardsListDb.Model;

namespace FlashcardsListDb
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            //((App)App.Current).ResumeAtTodoId = -1;
            QuestionView.ItemsSource = await App.Database.GetItemsAsync();
            //listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return; // has been set to null, do not 'process' tapped event
            //Card theitem = (Card)((ListView)sender).SelectedItem;
            DisplayAlert("Answer", "The Answer is: " + ((Card)((ListView)sender).SelectedItem).Answer, "OK");
            Console.WriteLine("Tapped: " + e.Item);
            ((ListView)sender).SelectedItem = null; // de-select the row
        }
    }
}
