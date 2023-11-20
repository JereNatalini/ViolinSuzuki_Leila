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
            // TODO: esta línea de código carga datos en la tabla 'dataSetReportes.SP_REPORTE_PROGRESO' Puede moverla o quitarla según sea necesario.
            this.sP_REPORTE_PROGRESOTableAdapter.Fill(this.dataSetReportes.SP_REPORTE_PROGRESO,idProgreso);

            this.reportViewer1.RefreshReport();
        }
    }
}
