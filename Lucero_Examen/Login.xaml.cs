using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lucero_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            // Almacenar datos en variables
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "estudiante2021" && contrasena == "uisrael2021")
            {
                //Navegando a la ventana 1
                await Navigation.PushAsync(new MainPage(usuario, contrasena));
            }
            else
            {
                await DisplayAlert("Mensaje de error", "Usuario y/o contraseña no valida", "ok");
            }
        }
    }
}