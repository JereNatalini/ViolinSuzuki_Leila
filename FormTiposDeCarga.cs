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
    public partial class FormTiposDeCarga : Form
    {
        private FormCargarPersona formCargarPersona;
        private FormCargarViolines formCargarViolines;

        public FormTiposDeCarga()
        {
            InitializeComponent();
        }
        private void AbrirFormCargarPersona()
        {
            formCargarPersona = new FormCargarPersona();
            formCargarPersona.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formCargarPersona.Show();
            this.Hide();
        }
        private void AbrirFormCargarViolines()
        {
            formCargarViolines = new FormCargarViolines();
            formCargarViolines.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formCargarViolines.Show();
            this.Hide();
        }
        private void btnPersona_Click(object sender, EventArgs e)
        {
            AbrirFormCargarPersona();
        }

        private void btnViolines_Click(object sender, EventArgs e)
        {
            AbrirFormCargarViolines();
        }

        private void FormTiposDeCarga_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
