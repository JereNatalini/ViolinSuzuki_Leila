using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolinSuzuki_Leila
{
    public partial class FormListarAlumnosPagos : Form
    {
        public FormListarAlumnosPagos()
        {
            InitializeComponent();
        }

        private void FormListarAlumnosPagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_LISTAR_ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSetPrincipal.SP_LISTAR_ALUMNOS);

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.CurrentCell.ColumnIndex == 4)
            {
                Alumno a = new Alumno();
                DataGridViewRow filaSeleccionada = dgvAlumnos.Rows[e.RowIndex];
                a.IdAlumno = (int)filaSeleccionada.Cells[0].Value;
                a.Nombre = filaSeleccionada.Cells[1].Value.ToString();
                a.Apellido = filaSeleccionada.Cells[2].Value.ToString();
                FormListarResponsablesPagos formListarResponsablesPagos = new FormListarResponsablesPagos(a);
                formListarResponsablesPagos.ShowDialog();
                this.Close();
            }
        }
    }
}
