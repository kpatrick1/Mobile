using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlashcardsPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CardList cl = new CardList();

            cbopicker.ItemsSource = CardList.lst;

        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = cbopicker.SelectedIndex;

            if (selectedIndex != -1)
            {
                Answer.Text = CardList.lst[selectedIndex].Answer.ToString();
                //Answer.Text = cbopicker.Items[selectedIndex];
            }
        }
    }
}
