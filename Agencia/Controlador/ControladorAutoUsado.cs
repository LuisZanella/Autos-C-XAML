using Agencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Agencia.Controlador
{
    class ControladorAutoUsado
    {
        public void Add(AutoUsado _AutoUsado, bool tipoAuto) {
            if (tipoAuto == true)
                MessageBox.Show("Se ha agragado un nuevo auto");
        }
    }
}
