using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Annies_Store.Views
{
    /// <summary>
    /// Lógica de interacción para AcercaDe.xaml
    /// </summary>
    public partial class AcercaDe : Window
    {
        public AcercaDe()
        {
            InitializeComponent();

            string tema = Properties.Settings.Default.Tema;

            fondo.Source = new BitmapImage(new Uri(@"/SCS/IMG/" + tema + ".png", UriKind.Relative));
        }

        private void Cerrar(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
