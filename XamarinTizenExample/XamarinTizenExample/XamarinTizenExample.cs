using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinTizenExample
{
    public class App : Application
    {
        Label label;
        int clicks = 0;

        public App()
        {
            Button button = new Button
            {
                Text = "Click aquí",
                BackgroundColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center,
            };
            button.Clicked += OnButtonClicked;
            label = new Label
            {
                Text = "",
                HorizontalOptions = LayoutOptions.Center,
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Bienvenido a Tizen con Xamarin Forms!"
                        },
                        button,
                        label
                    }
                }
            };
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            clicks += 1;
            label.Text = String.Format("Número de clicks: {0}", clicks);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
