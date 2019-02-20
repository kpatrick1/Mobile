using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            double billAmount = double.Parse(txtBillAmount.Text);
            double tipPercent = double.Parse(txtTipRate.Text)/100;

            double _tipAmount = billAmount * tipPercent;
            double _billAmount = billAmount + _tipAmount;
            tipAmount.Text = "Tip Amount: $" + _tipAmount.ToString();
            totalBill.Text = "Total Bill: $" + _billAmount.ToString();

        }
    }
}
