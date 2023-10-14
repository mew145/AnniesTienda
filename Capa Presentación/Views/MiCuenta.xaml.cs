using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Annies_Store.SCS.Boxes;
using Capa_Negocio;

namespace Annies_Store.Views
{
    public partial class MiCuenta : Window
    {
        public MiCuenta()
        {
            InitializeComponent();
            string tema = Properties.Settings.Default.Tema;

            fondo.Source = new BitmapImage(new Uri(@"/SCS/IMG/" + tema + ".png", UriKind.Relative));

            cargardatos();
        }
        Error error;
        void cargardatos()
        {
            CN_Usuarios cn = new CN_Usuarios();
            var a = cn.Cargar(Properties.Settings.Default.IdUsuario);
            try
            {
                lblnombre.Text = "Nombres: " + a.Nombres;
                lblApellidos.Text = "Apellidos: " + a.Apellidos;
                lblCorreo.Text = "Correo: " + a.Correo;
                lblPrivilegio.Text = "Privilegio: Nivel " + a.Privilegio;

                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.Source = (ImageSource)imgs.ConvertFrom(a.Img);
            }
            catch (Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }
        }

        private void Cerrar(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
