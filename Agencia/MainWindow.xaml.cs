using Agencia.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Agencia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rdbAUsado_Checked(object sender, RoutedEventArgs e)
        {
            AutoWindow _WAW = new AutoWindow();
            _WAW.Show();
            _WAW.lblTitulo.Content = "Autos Usados";
            _WAW.lblVariable.Content = "Kilometraje: ";
        }

        private void rdbANuevo_Checked(object sender, RoutedEventArgs e)
        {
            AutoWindow _WAW = new AutoWindow();
            _WAW.Show();
            _WAW.lblTitulo.Content = "Autos Nuevos";
            _WAW.txtVariable.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
