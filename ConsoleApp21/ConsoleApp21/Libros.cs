using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Libros
    {
        public Libros(string dTitulo, string dAutor, string dEditorial, int dAnioPublicado)
        {
            titulo = dTitulo;
            autor = dAutor;
            editorial = dEditorial;
            anioPublicado = dAnioPublicado;
        }
        public string titulo { set; get; }
        public string autor { set; get; }
        public string editorial { set; get; }
        public int anioPublicado { set; get; }

        public override string ToString()
        {
            return titulo + "  " + autor + "  " + editorial + "  " + anioPublicado.ToString();
        }
    }
}
