using System.Windows;

namespace Annies_Store.SCS.Boxes
{
    /// <summary>
    /// Lógica de interacción para Error.xaml
    /// </summary>
    public partial class Error : Window
    {
        public Error()
        {
            InitializeComponent();
        }

        private void OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
