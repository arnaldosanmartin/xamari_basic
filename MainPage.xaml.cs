using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            var layout = new StackLayout {Orientation= StackOrientation.Vertical, Margin=20 };
            var boton = new Button { Text = "Presiona"};
            this.Content = layout;

            layout.Children.Add(boton);
            
            boton.Clicked += Boton_Clicked;
		}

        private void Boton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hi","Hello world","ok");
        }
    }
}
