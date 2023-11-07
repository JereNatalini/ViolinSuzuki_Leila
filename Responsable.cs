using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    internal class Responsable
    {
        private int idResonsable;
        private int idTipoResp;

        public int IdResponsable
        {
            get { return idResonsable; }
            set { idResonsable = value; }
        }

        public int IdTipoResp
        {
            get { return idTipoResp; }
            set { idTipoResp = value; }
        }
    }
}
