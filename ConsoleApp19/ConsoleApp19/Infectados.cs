using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Infectados
    {
        public Infectados(string dnombre, string dsegundoNombre, string dapellido, string dsegundoApellido, int dedad, string dsexo, string destado)
        {
            nombre = dnombre;
            segundoNombre = dsegundoNombre;
            apellido = dapellido;
            segundoNombre = dsegundoApellido;
            edad = dedad;
            sexo = dsexo;
            estado = destado;
        }
        public string nombre { set; get; }
        public string segundoNombre { set; get; }
        public string apellido { set; get; } 
        public string segundoApellido { set; get; }
        public int edad { set; get; }
        public string sexo { set; get; }
        public string estado { set; get; }

        public override string ToString()
        {
            return nombre + "  "+ segundoNombre +"  "+ apellido + "  " +segundoApellido+"  "+ edad.ToString() + "  " + sexo + "  " + estado;
        }
    }
}
