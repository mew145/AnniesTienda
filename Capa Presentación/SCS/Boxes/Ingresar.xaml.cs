using System.Windows;

namespace Annies_Store.SCS.Boxes
{

    public partial class Ingresar : Window
    {
        public Ingresar()
        {
            InitializeComponent();
            tbcantidad.Focus();
        }
        Error error;
        private void OK(object sender, RoutedEventArgs e)
        {
            try
            {
                bool esnumerico = decimal.TryParse(tbcantidad.Text, out _);

                if (esnumerico)
                {
                    Total = decimal.Parse(tbcantidad.Text);
                    Efectivo = decimal.Parse(tbcantidad.Text);
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            }
            catch (System.Exception ex)
            {
                error = new Error();
                error.lblerror.Text = ex.Message;
                error.ShowDialog();
            }
        }

        public decimal Total { get; set; }
        public decimal Efectivo { get; set; }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
