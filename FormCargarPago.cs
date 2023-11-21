using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolinSuzuki_Leila
{
    public partial class FormCargarPago : Form
    {
        Helper helper;
        public Alumno alumno { get; set; }
        public Responsable responsable { get; set; }
        public FormCargarPago(Alumno alumno, Responsable responsable)
        {
            helper = new Helper();
            InitializeComponent();
            this.alumno = alumno;
            this.responsable = responsable;
        }

        public FormCargarPago(Alumno a)
        {
            alumno = a;
            responsable = null;
        }


        private void FormCargarPago_Load(object sender, EventArgs e)
        {
            CargarCombo("FORMA_PAGO", cboFormaPago);
            lblAlumno.Text = alumno.Nombre+ " " + alumno.Apellido ;
            if (responsable != null )
            {
                lblResponsable.Text = responsable.Nombre + " " + responsable.Apellido;
            }
            else
            {
                lblResponsable.Text = alumno.Nombre + " " + alumno.Apellido;
            }

        }

        

        public void CargarCombo(string nombreTabla, System.Windows.Forms.ComboBox comboBox)
        {
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_" + nombreTabla);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = dt.Columns[1].ColumnName;
            comboBox.ValueMember = dt.Columns[0].ColumnName;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            int monto = Convert.ToInt32(txtMonto.Text);
            DateTime fechaPago = dtpFechaPago.Value.Date;
            int idAlumno = alumno.IdAlumno;
            int idResponsable = responsable.IdResponsable;
            int idFormaPago = cboFormaPago.SelectedIndex + 1;
            string concepto = txtConcepto.Text;


            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@monto", monto));
            lst.Add(new Parametro("@fecha_pago", fechaPago));
            lst.Add(new Parametro("@idAlumno", idAlumno));
            lst.Add(new Parametro("@idResponsable", idResponsable));
            lst.Add(new Parametro("@idFormaPago", idFormaPago));
            lst.Add(new Parametro("@concepto", concepto));

            bool resultado = helper.Insertar("SP_INSERTAR_PAGO", lst);

            if (resultado)
            {
                MessageBox.Show("Pago ingresado con exito!", "Atencion!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Error al ingresar el pago", "Atencion!", MessageBoxButtons.OK);

            }
            Close();
        }
    }
}
