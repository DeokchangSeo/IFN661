using System;
using Xamarin.Forms;

namespace rice_g
{
    public class Farmer2 : ContentPage
    {
        Label b, c, d;
        public Farmer2()
        {
            b = new Label
            {
                Text = "Rice growing advisor",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            c = new Label
            {
                Text = "Water level:\r\n"+
                       "Standard Water level: 4-5cm\r\n"+
                       "Current Water level: 2cm"
            };
            
            d = new Label
            {
                Text = "Suggestions",
                VerticalTextAlignment =TextAlignment.End

        };

            this.Content = new StackLayout
            {
                Children =
                {
                      new StackLayout
                      {
                          Orientation = StackOrientation.Vertical,
                          Children =
                          {
                              b,
                              c,
                              d                    
                          }
                      }
                }
            };
        }
    }
}
