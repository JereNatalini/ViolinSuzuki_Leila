using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila.Clases
{
    public class Progreso
    {
		private int idProgreso;
		private DateTime fechaHora;
		private Alumno alumno;
		private Responsable responsable;

        public Progreso(Alumno alumno, Responsable responsable)
        {
			idProgreso = 0;
			fechaHora = DateTime.Now;
			this.responsable = responsable;
			this.alumno = alumno;
        }

        public Progreso(Alumno alumno)
        {
            idProgreso = 0;
            fechaHora = DateTime.Now;
            this.responsable = null;
            this.alumno = alumno;
        }


        public Responsable pResponsable
		{
			get { return responsable; }
			set { responsable = value; }
		}


		public Alumno pAlumno
		{
			get { return alumno; }
			set { alumno = value; }
		}

		public DateTime pFechaHora
		{
			get { return fechaHora; }
			set { fechaHora = value; }
		}

		public int pIdProgreso
		{
			get { return idProgreso; }
			set { idProgreso = value; }
		}

	}
}
