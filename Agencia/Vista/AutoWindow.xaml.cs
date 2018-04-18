using Agencia.Controlador;
using Agencia.Modelo;
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
using System.Windows.Shapes;

namespace Agencia.Vista
{
    /// <summary>
    /// Interaction logic for AutoWindow.xaml
    /// </summary>
    public partial class AutoWindow : Window
    {
        public AutoWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ConvertirAutoUsado();
        }
        public void ConvertirAutoUsado() {
            ControladorAutoUsado _CAU = new ControladorAutoUsado();
            ControladorAutoNuevo _CAN = new ControladorAutoNuevo();
            AutoUsado _AutoUsado = new AutoUsado();
            bool TipoCarro = true;
            Auto _Auto = new Auto();
            _Auto.Nombre = txtName.Text;
            _Auto.Marca = txtMarca.Text;
            _Auto.Precio = Double.Parse(txtPrecio.Text);
            _AutoUsado.Auto = _Auto;
            if (txtVariable.Text != "")
            {
                _AutoUsado.Kilometraje = Int32.Parse(txtVariable.Text);
                TipoCarro = false;
                _CAN.Add(_AutoUsado, TipoCarro);        
            }
            else {
                _CAU.Add(_AutoUsado, TipoCarro);
            }
            
        }
    }
}
