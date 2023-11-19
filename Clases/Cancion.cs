using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila.Clases
{
    public class Cancion
    {
        public int idCancion { get; set; }
        public string nombreCancion { get; set; }

        public Cancion(int id, string nombre)
        {
            idCancion = id;
            nombreCancion = nombre;
        }
    }
}
