using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }
       void but(System.Object sender,System.EventArgs e)
        {
            int p = int.Parse(UserInput.Text);
            int r = int.Parse(UserInput2.Text);
            int n = int.Parse(year.Text);
            int x = (p * n*r)/100;
            int z = x + p;


            var y = x.ToString();
            Ia.Text = y;
            var k = z.ToString();
            Ta.Text = k;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UserInput.Text = String.Empty;
            UserInput2.Text = String.Empty;
            year.Text=String.Empty;
            Ia.Text = String.Empty;
            Ta.Text = String.Empty;


        }
    }
}
