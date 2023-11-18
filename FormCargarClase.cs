using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolinSuzuki_Leila.Clases;

namespace ViolinSuzuki_Leila
{
    public partial class FormCargarClase : Form
    {
        private Progreso progreso;
        private List<DetalleProgreso> lDetallesProgreso;




        public FormCargarClase(Progreso p)
        {
            progreso = p;
            lDetallesProgreso = new List<DetalleProgreso>();
            InitializeComponent();
        }

        private void FormCargarClase_Load(object sender, EventArgs e)
        {

        }
    }
}
