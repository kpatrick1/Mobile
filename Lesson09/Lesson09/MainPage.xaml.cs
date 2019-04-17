using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson09
{
    public partial class MainPage : TabbedPage
    {


        public MainPage()
        {

            InitializeComponent();
        }

        void OnFocused(object sender, EventArgs e)
        {
            App.ui.UserName = "Joe";
        }

    }
}
