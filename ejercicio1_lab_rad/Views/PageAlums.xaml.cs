using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio1_lab_rad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAlums : ContentPage
    {
        public PageAlums()
        {
            InitializeComponent();
            
        } 
        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            var alum = new Models.alumno
            {
                Nombres = txtnombre.Text,
                Apellidos = txtapellidos.Text,
                Edad = txtedad.Text,
                Correo = txtcorreo.Text,

            };

            var page = new Views.PageResultado();
            page.BindingContext = alum;
            await Navigation.PushAsync(page); 


        }
    }
}