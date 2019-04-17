using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Lesson09
{
    public partial class Results : ContentPage
    {
        public Results()
        {

            InitializeComponent();

         //   BindingContext = App.ui.UserName;
            results.Text = App.ui.UserName;
        }

        protected void OnStart()
        {
            // Handle when your app starts
            results.Text = App.ui.UserName;
        }

        protected void OnResume()
        {
            // Handle when your app resumes
            results.Text = App.ui.UserName;
        }
    }
}
