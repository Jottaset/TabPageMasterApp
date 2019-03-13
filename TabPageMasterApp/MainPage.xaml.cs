using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabPageMasterApp
{
    public partial class MainPage : ContentPage
    {
        void Concatenando(object sender, System.EventArgs e)
        {
            label_result.Text = label_01.Text + " " + label_02.Text;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
