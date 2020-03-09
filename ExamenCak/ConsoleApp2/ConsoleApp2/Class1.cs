using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Registro
    {
        public Registro(int mesa, string eleccion, string ciudad, int mas, int cc, int juntos, int crecer)
        {
            this.mesa = mesa;
            this.eleccion=eleccion;
            this.ciudad=ciudad;
            this.mas = mas;
            this.cc = cc;
            this.juntos = juntos;
            this.crecer = crecer;
        }

        public int mesa { get; set; }
        public String eleccion { get; set; }
        public string ciudad { get; set; }
        public int mas { get; set; }
        public int cc { get; set; }
        public int juntos { get; set; }
        public int crecer { get; set; } 


    }

}

