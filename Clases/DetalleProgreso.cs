using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    public class DetalleProgreso
    {
        private int idDetalleProgreso;
        private int idProgreso;
        private int idLibro;
        private int idCancion;
        private string Observaciones;

        public string pObservaciones
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }


        public int pIdCancion
        {
            get { return idCancion; }
            set { idCancion = value; }
        }


        public int pIdLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }


        public int pIdProgreso
        {
            get { return idProgreso; }
            set { idProgreso = value; }
        }


        public int pIdDetalleProgreso
        {
            get { return idDetalleProgreso; }
            set { idDetalleProgreso = value; }
        }

        public DetalleProgreso()
        {
            
        }
    }
}
