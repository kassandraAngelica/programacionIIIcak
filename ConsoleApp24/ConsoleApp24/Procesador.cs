using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Procesador
    {
        string Marca;
        int CantidadDeNucleos;
        double frecuencia;
        public Procesador(string Marca,int CantidadDeNucleos, double frecuencia)
        {
            this.Marca = Marca;
            this.CantidadDeNucleos = CantidadDeNucleos;
            this.frecuencia = frecuencia;
        }
        public override string ToString()
        {
            return Marca + "  " + CantidadDeNucleos.ToString()+ "  " + frecuencia.ToString();
        }
    }
}
