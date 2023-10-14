﻿using Annies_Store.SCS;
using Annies_Store.SCS.Boxes;
using Annies_Store.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Annies_Store
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Error error;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Dashboard();
            string tema = Properties.Settings.Default.Tema;

            if (Properties.Settings.Default.Privilegio!=1)
            {
                lvproductos.Visibility = Visibility.Hidden;
                lvusuarios.Visibility = Visibility.Hidden;
            }

            this.Temas.Items.Add("Pink");
            this.Temas.Items.Add("Dark");
            this.Temas.Items.Add("Purple");

            if (tema != null)
            {
                if (tema == "Pink")
                    Temas.SelectedIndex = 0;
                if (tema == "Dark")
                    Temas.SelectedIndex = 1;
                if (tema == "Purple")
                    Temas.SelectedIndex = 2;
            }
            CargarTema();
        }

        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.8;
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PreviewMouseLeftBottonDownBG(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Close();
        }

        private void Usuarios_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Productos();
        }

        private void Dashboard(object sender, RoutedEventArgs e)
        {
            DataContext = new Dashboard();
        }

        private void POS(object sender, RoutedEventArgs e)
        {
            DataContext = new POS();
        }

        private void MiCuenta(object sender, RoutedEventArgs e)
        {
            MiCuenta mc = new MiCuenta();
            mc.ShowDialog();
        }

        private void AcercaDe(object sender, RoutedEventArgs e)
        {
            AcercaDe ac = new AcercaDe();
            ac.ShowDialog();
        }

        #region MOVER VENTANA

        private void Mover(Border header)
        {
            var restaurar = false;

            header.MouseLeftButtonDown += (s, e) =>
            {
                if (e.ClickCount == 2)
                {
                    if ((ResizeMode == ResizeMode.CanResize) || (ResizeMode == ResizeMode.CanResizeWithGrip))
                    {
                        CambiarEstado();
                    }
                }
                else
                {
                    if (WindowState == WindowState.Maximized)
                    {
                        restaurar = true;
                    }
                    DragMove();
                }
            };

            header.MouseLeftButtonUp += (s, e) =>
            {
                restaurar = false;
            };

            header.MouseMove += (s, e) =>
            {
                if (restaurar)
                {
                    try
                    {
                        restaurar = false;
                        var mouseX = e.GetPosition(this).X;
                        var width = RestoreBounds.Width;
                        var x = mouseX - width / 2;

                        if (x < 0)
                        {
                            x = 0;
                        }
                        else if (x + width > SystemParameters.PrimaryScreenWidth)
                        {
                            x = SystemParameters.PrimaryScreenWidth - width;
                        }

                        WindowState = WindowState.Normal;
                        Left = x;
                        Top = 0;
                        DragMove();
                    }
                    catch (System.Exception ex)
                    {
                        error = new Error();
                        error.lblerror.Text= ex.Message;
                        error.ShowDialog();
                    }
                }
            };
        }

        private void CambiarEstado()
        {
            switch (WindowState)
            {
                case WindowState.Normal:
                    {
                        WindowState = WindowState.Maximized;
                        break;
                    }
                case WindowState.Maximized:
                    {
                        WindowState = WindowState.Normal;
                        break;
                    }
            }
        }

        private void RestaurarVentana(object sender, RoutedEventArgs e)
        {
            Mover(sender as Border);
        }

        #endregion

        private void CambiarTema(object sender, SelectionChangedEventArgs e)
        {
            if (Temas.SelectedIndex == 0)
            {
                Properties.Settings.Default.Tema = "Pink";
            }
            else if (Temas.SelectedIndex == 1)
            {
                Properties.Settings.Default.Tema = "Dark";
            }
            else if (Temas.SelectedIndex == 2)
            {
                Properties.Settings.Default.Tema = "Purple";
            }
            Properties.Settings.Default.Save();
            CargarTema();
        }
        public void CargarTema()
        {
            Temas temas = new Temas();
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(temas.CargarTema());
        }
    }
}
