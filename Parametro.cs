using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    internal class Parametro
    {
        private object valor;
        private string nombre;
        public Parametro(string Nombre, object Valor)
        {
            nombre = Nombre;
            valor = Valor;
        }

        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
