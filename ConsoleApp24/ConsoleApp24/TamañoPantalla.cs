using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class TamañoPantalla
    {
        int alto;
        int ancho;
        public TamañoPantalla(int alto, int ancho)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        public override string ToString()
        {
            return alto.ToString() + "  " + ancho.ToString();
        }
    }
}
