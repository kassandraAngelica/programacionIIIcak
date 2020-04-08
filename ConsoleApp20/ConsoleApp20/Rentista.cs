using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Rentista
    {
        public Rentista(string dnombre, string dsegundoNombre, string dapellido, string dsegundoApellido, int dedad, string dsexo, string dsector)
        {
            nombre = dnombre;
            segundoNombre = dsegundoNombre;
            apellido = dapellido;
            segundoNombre = dsegundoApellido;
            edad = dedad;
            sexo = dsexo;
            sector = dsector;
        }
        public string nombre { set; get; }
        public string segundoNombre { set; get; }
        public string apellido { set; get; }
        public string segundoApellido { set; get; }
        public int edad { set; get; }
        public string sexo { set; get; }
        public string sector { set; get; }

        public override string ToString()
        {
            return nombre + "  " +segundoNombre+ "  " + apellido + "  " +segundoApellido+ "  " + edad.ToString() + "  " + sexo + "  " + sector;
        }
    }
}
