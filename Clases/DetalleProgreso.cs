using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViolinSuzuki_Leila.Clases;

namespace ViolinSuzuki_Leila
{
    public class DetalleProgreso
    {
        private Cancion cancion;
        private string Observaciones;

        public string pObservaciones
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }


        public Cancion pCancion
        {
            get { return cancion; }
            set { cancion = value; }
        }

        public DetalleProgreso(Cancion c, string obs)
        {
            cancion = c;
            Observaciones = obs;
        }
    }
}
