using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace Lesson09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage : ContentPage
    {
        public NavPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var contact = new UserInfo
            {
                UserName = editor.Text
            };

            var secondpage = new Results();
            secondpage.BindingContext = contact;

            await Navigation.PushAsync(secondpage);
        }

        void OnChanged(object sender, EventArgs e)
        {
            string input = editor.Text;
            App.ui.UserName = input;

        }
    }
}
