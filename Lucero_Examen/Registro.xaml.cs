using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lucero_Examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string contrasena)
        {
            InitializeComponent();
            //Envio a los laber
            lblUsuario.Text = usuario;
            lblContrasena.Text = contrasena;

            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;
        }

        private void txtMinicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double minicial = Convert.ToDouble(txtMinicial.Text);

                if (minicial >= 1 && minicial <= 1799 )
                {
                    
                }
                else
                {
                    DisplayAlert("Alerta", "Monto inical debe ser mayor a 1 y menor a 1799", "ok");
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        private void txtResultado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void btnMensual_Clicked(object sender, EventArgs e)
        {
            

            
            try
            {
                string usuario = lblUsuario.Text;
               

                //Ingres monto minimo
                double minicial = Convert.ToDouble(txtMinicial.Text);
                //Operacion 1

                double cuota = 1800 - minicial;
                double mensual = (cuota / 3);
                double pago = mensual + (mensual * 0.05);
                double pagofinal = cuota + (pago * 3);

                //Convertir a string para visualizar en un Entry
                txtMensual.Text = Convert.ToString(pagofinal);
                await Navigation.PushAsync(new Resumen(usuario, Convert.ToString(pagofinal)));
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "Ok");
            }

            
        }

        private void txtMensual_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
