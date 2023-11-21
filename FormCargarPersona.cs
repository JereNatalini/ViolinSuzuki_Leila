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
    public partial class FormCargarPersona : Form
    {
        Helper helper;

        public FormCargarPersona()
        {
            InitializeComponent();
            helper = new Helper();
        }


        private void InsertarDatos(bool esAlumno)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre", txtNombre.Text));
            parametros.Add(new Parametro("@apellido", txtApellido.Text));
            parametros.Add(new Parametro("@dni", txtDni.Text));
            parametros.Add(new Parametro("@calle", txtCalle.Text));
            parametros.Add(new Parametro("@altura", txtAltura.Text));
            parametros.Add(new Parametro("@id_ciudad", cboCiudad.SelectedIndex + 1)/*Le sumo 1 por diferencia de indices en SSMS*/);
            parametros.Add(new Parametro("@observaciones", txtObservaciones.Text));
            string storedProcedure = esAlumno ? "SP_CARGAR_ALUMNO" : "SP_CARGAR_RESPONSABLE";
            //Guarda en un string el sp correspondiente

            if (esAlumno)
            {
                parametros.Add(new Parametro("@colegio", txtColegio.Text));
                parametros.Add(new Parametro("@fecha_nac", dtpFechaNac.Value));
            }
            else
            {
                parametros.Add(new Parametro("@id_tipo_responsable", cboTipoResp.SelectedValue));
            }

            if (Validar())
            {
                bool resultado = helper.Insertar(storedProcedure, parametros);

                if (resultado)
                {
                    List<Parametro> paramContacto = new List<Parametro>();
                    string id_alumno = "SP_OBTENER_ID_ALUMNO";
                    string id_responsable = "SP_OBTENER_ID_RESPONSABLE";
                    int? idAlumno = esAlumno ? ObtenerUltimoID(id_alumno) : null;
                    int? idResponsable = esAlumno ? null : ObtenerUltimoID(id_responsable);
                    bool res;



                    if (!string.IsNullOrEmpty(txtTelefono.Text))
                    {
                        paramContacto.Add(new Parametro("@id_alumno", idAlumno));
                        paramContacto.Add(new Parametro("@id_responsable", idResponsable));
                        paramContacto.Add(new Parametro("@id_tipo_contacto", 1));
                        paramContacto.Add(new Parametro("@contacto", txtTelefono.Text));

                        res = helper.Insertar("SP_INSERTAR_CONTACTO", paramContacto);
                    }
                    if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                    {
                            paramContacto.Clear();
                        paramContacto.Add(new Parametro("@id_alumno", idAlumno));
                        paramContacto.Add(new Parametro("@id_responsable", idResponsable));
                        paramContacto.Add(new Parametro("@id_tipo_contacto", 2));
                        paramContacto.Add(new Parametro("@contacto", txtEmail.Text));

                        res = helper.Insertar("SP_INSERTAR_CONTACTO", paramContacto);
                    }
                    else
                    {
                        paramContacto.Add(new Parametro("@id_alumno", idAlumno));
                        paramContacto.Add(new Parametro("@id_responsable", idResponsable));
                        paramContacto.Add(new Parametro("@id_tipo_contacto", 1));
                        paramContacto.Add(new Parametro("@contacto", null));

                        res = helper.Insertar("SP_INSERTAR_CONTACTO", paramContacto);
                    }

                    //Hay que llamar al metodo para insertar el contacto


                    if (res)
                    {

                        MessageBox.Show("Carga Exitosa", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Pincho bro");
                    }

                }
            }
            
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtColegio.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDni.Text = "";
            txtAltura.Text = "";
            txtObservaciones.Text = "";
            dtpFechaNac.Value = DateTime.Now;
            cboProvincia.SelectedValue = 0;
            cboCiudad.SelectedValue = 0;
            cboTipoResp.SelectedValue = 0;

        }

        private int? ObtenerUltimoID(string sp)
        {
            int? ultimoId = helper.ConsultarID(sp);
            return ultimoId;
        }

        public void CargarCombo(string nombreTabla, System.Windows.Forms.ComboBox comboBox)
        {
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_" + nombreTabla);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = dt.Columns[1].ColumnName;
            comboBox.ValueMember = dt.Columns[0].ColumnName;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void CargarComboCiudades(int indice)
        {
            Parametro parametro = new Parametro("@id_provincia", indice);
            DataTable dt = helper.Consultar("SP_CARGAR_COMBO_CIUDAD", parametro);
            cboCiudad.DataSource = dt;
            cboCiudad.DisplayMember = dt.Columns[1].ColumnName;
            cboCiudad.ValueMember = dt.Columns[0].ColumnName;
            cboCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormCargarPersona_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            CargarCombo("PROVINCIA", cboProvincia);
            CargarCombo("TIPO_RESPONSABLE", cboTipoResp);
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (rbtAlumno.Checked)
            {
                InsertarDatos(true);
            }
            else
            {
                InsertarDatos(false);
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = cboProvincia.SelectedIndex;
            CargarComboCiudades(idProvincia + 1);/*Le sumo 1 por diferencia de indices en SSMS*/
        }

        private void rbtResponsable_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtResponsable.Checked)
            {
                rbtAlumno.Checked = false;
            }
            dtpFechaNac.Enabled = false;
            txtColegio.Enabled = false;
            cboTipoResp.Enabled = true;
        }

        private void rbtAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAlumno.Checked)
            {
                rbtResponsable.Checked = false;
            }
            dtpFechaNac.Enabled = true;
            txtColegio.Enabled = true;
            cboTipoResp.Enabled = false;
        }

        private bool Validar()
        {
            bool retornar = false;
            if (!rbtAlumno.Checked && !rbtResponsable.Checked)
            {
                MessageBox.Show("Debe seleccionar Alumno o Responsable.", "Error", MessageBoxButtons.OK);
                return retornar;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre.", "Error", MessageBoxButtons.OK);
                return retornar;
            }
            if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un apellido.", "Error", MessageBoxButtons.OK);
                return retornar;
            }
            if (txtDni.Text == string.Empty || txtDni.Text.Length<8)
            {
                MessageBox.Show("Debe ingresar un DNI valido.", "Error", MessageBoxButtons.OK);
                return retornar;
            }
            if (txtCalle.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una calle.", "Error", MessageBoxButtons.OK);
                return retornar;
            }
            if (txtAltura.Text == string.Empty) 
            {
                MessageBox.Show("Debe ingresar una altura.", "Error", MessageBoxButtons.OK);
                return retornar;
            }
            else
            {
                retornar = true;
                return retornar;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
    }
}
