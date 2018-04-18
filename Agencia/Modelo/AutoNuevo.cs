using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Modelo
{
    class AutoNuevo
    {
        private Auto _auto = new Auto();
        private int idAutoNuevo;
        private int modelo;
        internal Auto Auto { get => _auto; set => _auto = value; }
        public int IdAutoNuevo { get => idAutoNuevo; set => idAutoNuevo = value; }
        public int Modelo { get => modelo; set => modelo = value; }
    }
}
