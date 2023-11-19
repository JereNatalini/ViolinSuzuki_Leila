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
    public partial class FormListarResponsablesClases : Form
    {
        private Alumno alumno;
        public FormListarResponsablesClases(Alumno Alumno)
        {
            alumno = Alumno;
            InitializeComponent();
        }

        private void FormListarResponsablesClases_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_LISTAR_RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.sP_LISTAR_RESPONSABLESTableAdapter.Fill(this.dataSetPrincipal.SP_LISTAR_RESPONSABLES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Responsable responsable = new Responsable();

            if (dgvResponsables.CurrentCell.ColumnIndex == 5)
            {
                DataGridViewRow filaSeleccionada = dgvResponsables.Rows[e.RowIndex];
                responsable.IdResponsable = (int)filaSeleccionada.Cells[0].Value;
                responsable.Nombre = filaSeleccionada.Cells[1].Value.ToString();
                responsable.Apellido = filaSeleccionada.Cells[2].Value.ToString();
                responsable.IdTipoResp = (int)filaSeleccionada.Cells[4].Value;
                Progreso progreso = new Progreso(alumno, responsable);

                FormCargarClase formCargarClase = new FormCargarClase(progreso);
                formCargarClase.Show();
                Close();
            }
        }

        private void btnSinResponsable_Click(object sender, EventArgs e)
        {
            Progreso progreso = new Progreso(alumno);
            FormCargarClase formCargarClase = new FormCargarClase(progreso);
            formCargarClase.Show();
            Close();
        }
    }
}
