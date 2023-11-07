using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    internal class Alumno
    {
        private int idAlumno;
        private DateTime fec_nac;
        private string colegio;

        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public string Colegio
        {
            get { return colegio; }
            set { colegio = value; }
        }

        public DateTime Fec_nac
        {
            get { return fec_nac; }
            set { fec_nac = value; }
        }
    }
}
