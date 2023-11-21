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
    public partial class FormConsultarViolines : Form
    {
        public FormTiposDeConsulta FormularioAnterior { get; set; }
        public FormConsultarViolines()
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
        private void FormConsultarViolines_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_CONSULTAR_VIOLINES' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTAR_VIOLINESTableAdapter.Fill(this.dataSetPrincipal.SP_CONSULTAR_VIOLINES);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarFormularioAnterior();
        }
    }
}
