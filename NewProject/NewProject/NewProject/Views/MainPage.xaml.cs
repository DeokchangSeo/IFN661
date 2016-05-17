using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       public void OnButtonClick1(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        public void OnButtonClick2(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        public void OnButtonClick3(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}
