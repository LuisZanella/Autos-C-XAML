using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia.Modelo
{
    class Auto
    {
        private int idAuto;
        private double precio;
        private string nombre;
        private string marca;
        public int IdAuto { get => idAuto; set => idAuto = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
