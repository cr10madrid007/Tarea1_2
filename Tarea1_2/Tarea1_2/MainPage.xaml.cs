using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var procs = new Models.Procesos
            {
                nombre = this.txtNombre.Text,
                apellido = this.txtApellido.Text,
                edad = Convert.ToInt32(this.txtEdad.Text),
                correo = this.txtCorreo.Text

            };
            var pagina = new Page1();
            pagina.BindingContext = procs;
            await Navigation.PushAsync(pagina);

        }
    }
}
