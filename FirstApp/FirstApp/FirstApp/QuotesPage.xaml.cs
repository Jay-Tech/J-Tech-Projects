using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class QuotesPage : ContentPage
    {
        private string[] textHolder =
               {"Test 1",
               "Test 2",
               "Test 3"};
        private int count = 0;
        public QuotesPage()
        {
            InitializeComponent();


            quoteLabel.Text = textHolder[count];
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {

            count++;
            if (count == textHolder.Length)
            {
                count = 0;
            }

            quoteLabel.Text = textHolder[count];
        }
    }
}
