using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    internal abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string calle;
        private int altura;
        private int idCiudad;
        private DateTime fecha_alta;
        private string obvservaciones;
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }


        public string Observaciones
        {
            get { return obvservaciones; }
            set { obvservaciones = value; }
        }


        public DateTime Fecha_alta
        {
            get { return fecha_alta; }
            set { fecha_alta = value; }
        }


        public int IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
        }


        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
