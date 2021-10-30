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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string pagofinal)
        {
            InitializeComponent();
            //Envio a los laber
            lblUsuario.Text = usuario;

            txtPagoFinal.Text = pagofinal;
           
        }
    }
}