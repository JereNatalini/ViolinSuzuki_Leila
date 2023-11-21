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
    public partial class FormListarResponsablesPagos : Form
    {
        public Alumno alumno { get; set; }

        private FormCargarPago formCargarPago;
        public FormListarAlumnosPagos FormularioAnterior { get; set; }

        public FormListarResponsablesPagos(Alumno a)
        {
            alumno = a;
            InitializeComponent();
        }

        private void AbrirFormCargarPago(Alumno a, Responsable r)
        {
            formCargarPago = new FormCargarPago(a, r);
            formCargarPago.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formCargarPago.Show();
            this.Hide();
        }
        
        private void dgvResponsables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResponsables.CurrentCell.ColumnIndex == 5)
            {
                Responsable r = new Responsable();
                DataGridViewRow filaSeleccionada = dgvResponsables.Rows[e.RowIndex];
                r.IdResponsable = (int)filaSeleccionada.Cells[0].Value;
                r.Nombre = filaSeleccionada.Cells[1].Value.ToString();
                r.Apellido = filaSeleccionada.Cells[2].Value.ToString();
                AbrirFormCargarPago(alumno, r);
            }
        }
        private void MostrarFormularioAnterior()
        {
            if (FormularioAnterior != null)
            {
                FormularioAnterior.Show();
                this.Hide();
            }
        }
        private void FormListarResponsablesPagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_LISTAR_RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.sP_LISTAR_RESPONSABLESTableAdapter.Fill(this.dataSetPrincipal.SP_LISTAR_RESPONSABLES);

        }

        private void btnSinResponsable_Click(object sender, EventArgs e)
        {
            AbrirFormCargarPago(alumno, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarFormularioAnterior();
        }
    }
}
