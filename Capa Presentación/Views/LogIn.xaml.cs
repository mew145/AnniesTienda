using System.Windows;
using Annies_Store.SCS.Boxes;
using Capa_Negocio;

namespace Annies_Store.Views
{
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
            tbusuario.Focus();
        }

        Error error;

        private void Acceder(object sender, RoutedEventArgs e)
        {
            if (tbusuario.Text!="" && tbcontra.Text!="")
            {
                try
                {
                    Login(tbusuario.Text, tbcontra.Text);
                }
                catch (System.Exception ex)
                {
                    error = new Error();
                    error.lblerror.Text = ex.Message;
                    error.ShowDialog();
                }

            }
            else
            {
                error = new Error();
                error.lblerror.Text = "¡Los campos no pueden quedar vacíos!";
                error.ShowDialog();
            }
        }

        void Login(string usuario, string contra)
        {
            try
            {
                CN_Usuarios cn = new CN_Usuarios();
                var a = cn.LogIn(usuario, contra);

                if (a.IdUsuario > 0)
                {
                    Properties.Settings.Default.IdUsuario = a.IdUsuario;
                    Properties.Settings.Default.Privilegio = a.Privilegio;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    error = new Error();
                    error.lblerror.Text = "¡Credenciales incorrectas!";
                    error.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }

            
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
