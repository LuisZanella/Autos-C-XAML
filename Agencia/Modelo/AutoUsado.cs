using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Modelo
{
    class AutoUsado
    {
        private Auto _auto = new Auto();
        private int idAutoUsado;
        private int kilometraje;
        private bool estatus;

        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public int IdAutoUsado { get => idAutoUsado; set => idAutoUsado = value; }
        public bool Estatus { get => estatus; set => estatus = value; }
        internal Auto Auto { get => _auto; set => _auto = value; }
    }
}
