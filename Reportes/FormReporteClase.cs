using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolinSuzuki_Leila.Reportes
{
    public partial class FormReporteClase : Form
    {
        public int idProgreso { get; set; }
        public FormReporteClase()
        {
            InitializeComponent();
        }

        private void FormReporteClase_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
