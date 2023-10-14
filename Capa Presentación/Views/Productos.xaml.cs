using System.Windows;
using System.Windows.Controls;
using Annies_Store.SCS.Boxes;
using Capa_Negocio;

namespace Annies_Store.Views
{
    public partial class Productos : UserControl
    {
        #region Inicial
        public Productos()
        {
            InitializeComponent();
            Buscar("");
        }
        #endregion

        readonly CN_Productos obj_CN_Productos = new CN_Productos();
        Error error;
        #region Buscar

        public void Buscar(string buscar)
        {
            try
            {
                GridDatos.ItemsSource = obj_CN_Productos.BuscarProducto(buscar).DefaultView;

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
        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion

        #region CRUD

        #region Create
        private void Agregar_Producto(object sender, RoutedEventArgs e)
        {
            try
            {
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
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

        #region Read
        private void Consultar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.IdProducto = id;
                ventana.Consultar();
                ventana.Titulo.Text = "Consulta de Producto";
                ventana.tbNombre.IsEnabled = false;
                ventana.tbCodigo.IsEnabled = false;
                ventana.tbCantidad.IsEnabled = false;
                ventana.tbActivo.IsEnabled = false;
                ventana.tbPrecio.IsEnabled = false;
                ventana.cbGrupo.IsEnabled = false;
                ventana.tbUnidadMedida.IsEnabled = false;
                ventana.tbDescripcion.IsEnabled = false;
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

        #region Update
        private void Actualizar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.IdProducto = id;
                ventana.Consultar();
                ventana.Titulo.Text = "Actualizar Producto";
                ventana.tbNombre.IsEnabled = true;
                ventana.tbCodigo.IsEnabled = true;
                ventana.tbCantidad.IsEnabled = true;
                ventana.tbActivo.IsEnabled = true;
                ventana.tbPrecio.IsEnabled = true;
                ventana.cbGrupo.IsEnabled = true;
                ventana.tbUnidadMedida.IsEnabled = true;
                ventana.tbDescripcion.IsEnabled = true;
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

        #region Delete
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.IdProducto = id;
                ventana.Consultar();
                ventana.Titulo.Text = "Eliminar Producto";
                ventana.tbNombre.IsEnabled = false;
                ventana.tbCodigo.IsEnabled = false;
                ventana.tbCantidad.IsEnabled = false;
                ventana.tbActivo.IsEnabled = false;
                ventana.tbPrecio.IsEnabled = false;
                ventana.cbGrupo.IsEnabled = false;
                ventana.tbUnidadMedida.IsEnabled = false;
                ventana.tbDescripcion.IsEnabled = false;
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

        #endregion
    }
}
