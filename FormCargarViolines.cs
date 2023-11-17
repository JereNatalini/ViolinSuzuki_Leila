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
    public partial class FormCargarViolines : Form
    {
        Helper helper = new Helper();
        public FormCargarViolines()
        {
            InitializeComponent();
        }

        private void FormCargarViolines_Load(object sender, EventArgs e)
        {
            CargarCombo("MEDIDAS", cboMedidas);
            CargarCombo("MARCAS", cboMarcas);
        }

        private void CargarCombo(string nombreTabla, System.Windows.Forms.ComboBox comboBox)
        {
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_" + nombreTabla);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = dt.Columns[1].ColumnName;
            comboBox.ValueMember = dt.Columns[0].ColumnName;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarViolin_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿El violin pertenece a un alumno?", "Atencion!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                FormListadoDeAlumnos formListadoDeAlumnos = new FormListadoDeAlumnos();
                formListadoDeAlumnos.Show();
            }
        }
    }
}
