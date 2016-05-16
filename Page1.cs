using System;
using Xamarin.Forms;

namespace rice_g
{
   
    public class Main : ContentPage
    {
        Label a;
        Button WaterButton1, WaterButton2, SoilButton1, SoilButton2, SoilButton3, WeatherButton1, WeatherButton2;
        public Main()
        {
            a = new Label
            {
                Text = "Rice growing advisor",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions =LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            WaterButton1 = new Button
            {
                Text = "Water Level",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            

            WaterButton2 = new Button
            {
                Text = "Water Quality",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            SoilButton1 = new Button
            {
                Text = "Soil Moisture",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            SoilButton2 = new Button
            {
                Text = "NPK Level",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            SoilButton3 = new Button
            {
                Text = "Soil Temperature",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            WeatherButton1 = new Button
            {
                Text = "Humidity",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            WeatherButton2 = new Button
            {
                Text = "Air Pressure",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand

            };

            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        Children =
                        {   a,
                            WaterButton1,
                            WaterButton2,
                            SoilButton1,
                            SoilButton2,
                            SoilButton3,
                            WeatherButton1,
                            WeatherButton2,
                            
                        }
                    }
                }
            };
           
            }


        }
    }




