using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Divisas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            botonConvertir.Clicked += BotonConvertir_Clicked;
        }

        private async void BotonConvertir_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pesosEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar el valor en pesos", "Aceptar");
                return;
            }

            decimal pesos = decimal.Parse(pesosEntry.Text);
            decimal dollars = pesos / 42.50M;
            decimal euros = pesos / 55.57M;
            decimal pounds = pesos / 55.58M;

            dollarsEntry.Text = string.Format("{0:N2}", dollars);
            eurosEntry.Text = string.Format("{0:N2}", euros);
            poundsEntry.Text = string.Format("{0:N2}", pounds);
        }
    }
}
