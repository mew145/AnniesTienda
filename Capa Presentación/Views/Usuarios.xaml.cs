using System.Windows;
using System.Windows.Controls;
using Annies_Store.SCS.Boxes;
using Capa_Negocio;

namespace Annies_Store.Views
{
    public partial class Usuarios : UserControl
    {
        readonly CN_Usuarios objeto_CN_Usuarios = new CN_Usuarios();

        #region Inicial
        public Usuarios()
        {
            InitializeComponent();
            Buscar("");
        }
        #endregion
        Error error;
        #region Agregar
        private void Agregar(object sender, RoutedEventArgs e)
        {
            try
            {
                CRUDUsuarios ventana = new CRUDUsuarios();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.BtnCrear.Visibility = Visibility.Visible;
            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }

        }
        #endregion

        #region Consultar
        private void Consultar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDUsuarios ventana = new CRUDUsuarios();
                ventana.IdUsuario = id;
                ventana.Consultar();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.Titulo.Text = "Consulta de Usuario";
                ventana.tbNombres.IsEnabled = false;
                ventana.tbApellidos.IsEnabled = false;
                ventana.tbDUI.IsEnabled = false;
                ventana.tbNIT.IsEnabled = false;
                ventana.tbFecha.IsEnabled = false;
                ventana.tbTelefono.IsEnabled = false;
                ventana.tbCorreo.IsEnabled = false;
                ventana.cbPrivilegio.IsEnabled = false;
                ventana.tbUsuario.IsEnabled = false;
                ventana.tbContrasenia.IsEnabled = false;
                ventana.BtnSubir.IsEnabled = false;
            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }

        }
        #endregion

        #region Actualizar
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDUsuarios ventana = new CRUDUsuarios();
                ventana.IdUsuario = id;
                ventana.Consultar();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.Titulo.Text = "Actualizar Usuario";
                ventana.tbNombres.IsEnabled = true;
                ventana.tbApellidos.IsEnabled = true;
                ventana.tbDUI.IsEnabled = true;
                ventana.tbNIT.IsEnabled = true;
                ventana.tbFecha.IsEnabled = true;
                ventana.tbTelefono.IsEnabled = true;
                ventana.tbCorreo.IsEnabled = true;
                ventana.cbPrivilegio.IsEnabled = true;
                ventana.tbUsuario.IsEnabled = true;
                ventana.tbContrasenia.IsEnabled = true;
                ventana.BtnSubir.IsEnabled = true;
                ventana.BtnActualizar.Visibility = Visibility.Visible;
            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }

        }
        #endregion

        #region Eliminar
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDUsuarios ventana = new CRUDUsuarios();
                ventana.IdUsuario = id;
                ventana.Consultar();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.Titulo.Text = "Eliminar Usuario";
                ventana.tbNombres.IsEnabled = false;
                ventana.tbApellidos.IsEnabled = false;
                ventana.tbDUI.IsEnabled = false;
                ventana.tbNIT.IsEnabled = false;
                ventana.tbFecha.IsEnabled = false;
                ventana.tbTelefono.IsEnabled = false;
                ventana.tbCorreo.IsEnabled = false;
                ventana.cbPrivilegio.IsEnabled = false;
                ventana.tbUsuario.IsEnabled = false;
                ventana.tbContrasenia.IsEnabled = false;
                ventana.BtnSubir.IsEnabled = false;
                ventana.BtnEliminar.Visibility = Visibility.Visible;
            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }


        }
        #endregion

        #region Buscando

        public void Buscar(string buscar)
        {
            try
            {
                GridDatos.ItemsSource = objeto_CN_Usuarios.Buscar(buscar).DefaultView;
            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }
        }

        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion
    }
}
