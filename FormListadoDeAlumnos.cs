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
    public partial class FormListadoDeAlumnos : Form
    {
        public FormListadoDeAlumnos()
        {
            InitializeComponent();
        }

        private void FormListadoDeAlumnos_Load(object sender, EventArgs e)
        {
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


        }
    }
}
