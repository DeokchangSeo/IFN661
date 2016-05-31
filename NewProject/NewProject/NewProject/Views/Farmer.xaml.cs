using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class Farmer : ContentPage
    {
        public Farmer()
        {
            InitializeComponent();
        }

       

        public void OnButtonClicked4(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
        public void OnButtonClicked5(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Page5());
        }
        public void OnButtonClicked6(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Page6());
        }
        
    }
}
