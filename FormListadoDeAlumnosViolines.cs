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
    public partial class FormListadoDeAlumnosViolines : Form
    {
        Helper helper;
        private string Modelo { get; set; }
        private int IdMarca { get; set; }
        private int IdMedida { get; set; }
        private double Precio { get; set; }

        public FormListadoDeAlumnosViolines(string modelo, int idMarca, int idMedida, double precio)
        {
            InitializeComponent();
            helper = new Helper();
            Modelo = modelo;
            IdMarca = idMarca;
            IdMedida = idMedida;
            Precio = precio;

        }


        private void FormListadoDeAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal1.SP_LISTAR_ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSetPrincipal1.SP_LISTAR_ALUMNOS);
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_LISTAR_ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSetPrincipal.SP_LISTAR_ALUMNOS);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSetPrincipal.SP_LISTAR_ALUMNOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumno = new Alumno();
            List<Parametro> list = new List<Parametro>();
            //Ponerle nombre al boton de la accion
            if (dgvAlumnos.CurrentCell.ColumnIndex == 0)
            {
                DataGridViewRow filaSeleccionada = dgvAlumnos.Rows[e.RowIndex];
                alumno.IdAlumno = (int)filaSeleccionada.Cells[1].Value;
                alumno.Nombre = filaSeleccionada.Cells[2].Value.ToString();
                alumno.Apellido = filaSeleccionada.Cells[3].Value.ToString();

            }

            DialogResult result = MessageBox.Show("¿"+ "El dueño es : " + alumno.ToString() + "?", "Atencion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                
                list.Add(new Parametro("@modelo", Modelo)); 
                list.Add(new Parametro("@id_medida", IdMedida));
                list.Add(new Parametro("@id_marca", IdMarca));
                list.Add(new Parametro("@precio", Precio));
                list.Add(new Parametro("@id_alumno", alumno.IdAlumno));

                bool res = helper.Insertar("SP_CARGAR_VIOLIN", list);

                if (res)
                {
                    MessageBox.Show("Carga Exitosa","EXITO", MessageBoxButtons.OK);
                }

            }


            



        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSetPrincipal1.SP_LISTAR_ALUMNOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
