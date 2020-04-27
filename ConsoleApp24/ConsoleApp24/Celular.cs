using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Celular
    {
        Marca marca;
        string modelo;
        TamañoPantalla tPantalla;
        Color color;
        int memoria;
        Procesador procesador;
        private Marca samsung;
        private string v;
        private TamañoPantalla tamañoPantalla;
        private Color blanco;

        public Celular(Marca marca, string modelo, TamañoPantalla tPantalla, Color color, int memoria, Procesador procesador)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tPantalla = tPantalla;
            this.color = color;
            this.memoria = memoria;
            this.procesador = procesador;
        }

        public override string ToString()
        {
            return marca + "  " + modelo + "  " + tPantalla + "  " + color + "  " + memoria +"  "+ procesador;
        }
        public object clone()
        {
            return MemberwiseClone();
        }
    }
    enum Marca
    {
        Samsung ,Huawei ,LG ,Sonny
    }
    enum Color
    {
        Negro, Blanco, Plomo, Rosa
    }
}
