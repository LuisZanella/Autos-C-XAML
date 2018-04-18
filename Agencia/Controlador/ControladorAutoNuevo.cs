using Agencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Agencia.Controlador
{
    class ControladorAutoNuevo
    {
        public void Add(AutoUsado _AutoUsado, bool tipoAuto)
        {
            if (tipoAuto == false)
                MessageBox.Show("Se ha agregado el auto usado");
        }
                
    }
}
