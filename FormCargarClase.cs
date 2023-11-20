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
        Progreso progreso;
        Helper helper;

        public FormCargarClase(Progreso p)
        {
            helper = new Helper();
            progreso = p;
            InitializeComponent();
        }

        private void FormCargarClase_Load(object sender, EventArgs e)
        {
            if (progreso.pResponsable != null)
            {
                lblResponsable.Text = progreso.pResponsable.Apellido.ToString() + ", " + progreso.pResponsable.Nombre.ToString();
            }
            else
            {
                lblResponsable.Text = progreso.pAlumno.Apellido.ToString() + ", " + progreso.pAlumno.Nombre.ToString();
            }
            lblAlumno.Text = progreso.pAlumno.Apellido.ToString() + ", " + progreso.pAlumno.Nombre.ToString();
            lblNClase.Text = UltimoNumeroClase().ToString();
            lblFechaHora.Text = DateTime.Now.ToString();

            CargarCombo("LIBROS", cboLibro);

        }

        public int UltimoNumeroClase()
        {
            int? nClase = helper.ConsultarID("SP_ULTIMO_ID_PROGRESO")+1;
            if(nClase == 0 || nClase == null)
            {
                nClase = 1;
            }
            return nClase.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboLibro.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un Libro!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboCancion.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar una Cancion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtObservaciones.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe ingresar alguna observacion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifica si el DataGridView está vacío
            if (dgvDetalles.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    // Asegúrate de que la celda no sea nula antes de acceder a su Value
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString().Equals(cboCancion.Text))
                    {
                        MessageBox.Show("CANCION: " + cboCancion.Text + " ya se encuentra agregada!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }


            DataRowView item = (DataRowView)cboCancion.SelectedItem;

            int IdCancion = Convert.ToInt32(item.Row.ItemArray[0]);
            string NombreLibro = item.Row.ItemArray[2].ToString();
            string NombreCancion = item.Row.ItemArray[1].ToString();
            Cancion cancion = new Cancion(IdCancion, NombreCancion);
            string Observaciones = txtObservaciones.Text;

            DetalleProgreso detalle = new DetalleProgreso(cancion, Observaciones);
            progreso.AgregarDetalle(detalle);

            dgvDetalles.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[2], item.Row.ItemArray[1], txtObservaciones.Text });
        }

        public void CargarCombo(string nombreTabla, System.Windows.Forms.ComboBox comboBox)
        {
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_" + nombreTabla);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = dt.Columns[1].ColumnName;
            comboBox.ValueMember = dt.Columns[0].ColumnName;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void CargarComboCanciones(int indice)
        {
            Parametro parametro = new Parametro("@idLibro", indice);
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_CANCION", parametro);
            cboCancion.DataSource = dt;
            cboCancion.DisplayMember = dt.Columns[1].ColumnName;
            cboCancion.ValueMember = dt.Columns[0].ColumnName;
            cboCancion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idLibro = cboLibro.SelectedIndex;
            CargarComboCanciones(idLibro + 1); //SE LE SUMA 1 POR DIFERENCIAS DE INDICES ENTRE VS Y SSMS
        }

        private void GuardarProgreso()
        {
            if (helper.Confirmar(progreso))
            {
                MessageBox.Show("Clase Registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una actividad!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarProgreso();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
