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
using ViolinSuzuki_Leila.Reportes;

namespace ViolinSuzuki_Leila
{
    public partial class FormConsultarClases : Form
    {
        public FormTiposDeConsulta FormularioAnterior { get; set; }
        public FormConsultarClases()
        {
            InitializeComponent();
        }
        private void MostrarFormularioAnterior()
        {
            if (FormularioAnterior != null)
            {
                FormularioAnterior.Show();
                this.Hide();
            }
        }
        private void FormConsultarClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_CONSULTAR_PROGRESOS' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTAR_PROGRESOSTableAdapter.Fill(this.dataSetPrincipal.SP_CONSULTAR_PROGRESOS);

        }

        private void dgvConsultarClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarClases.CurrentCell.ColumnIndex == 4)
            {
                
                DataGridViewRow filaSeleccionada = dgvConsultarClases.Rows[e.RowIndex];
                int idProgreso= (int)filaSeleccionada.Cells[0].Value;

                FormReporteClase formReporteClase = new FormReporteClase();
                formReporteClase.idProgreso = idProgreso;
                formReporteClase.ShowDialog();
                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarFormularioAnterior();
        }
    }
}
