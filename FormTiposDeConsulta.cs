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
    public partial class FormTiposDeConsulta : Form
    {
        private FormConsultarAlumnos formConsultarAlumnos;
        private FormConsultarClases formConsultarClases;
        private FormConsultarResponsables formConsultarResponsables;
        private FormConsultarViolines formConsultarViolines;
        public FormTiposDeConsulta()
        {
            InitializeComponent();
        }
        private void AbrirFormConsultarAlumnos()
        {
            formConsultarAlumnos = new FormConsultarAlumnos();
            formConsultarAlumnos.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formConsultarAlumnos.Show();
            this.Hide();
        }
        private void AbrirFormConsultarClases()
        {
            formConsultarClases = new FormConsultarClases();
            formConsultarClases.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formConsultarClases.Show();
            this.Hide();
        }
        private void AbrirFormConsultarResponsables()
        {
            formConsultarResponsables = new FormConsultarResponsables();
            formConsultarResponsables.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formConsultarResponsables.Show();
            this.Hide();
        }
        private void AbrirFormConsultarViolines()
        {
            formConsultarViolines = new FormConsultarViolines();
            formConsultarViolines.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formConsultarViolines.Show();
            this.Hide();
        }
        private void btnConsultarAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormConsultarAlumnos();
        }

        private void btnConsultarResponsables_Click(object sender, EventArgs e)
        {
            AbrirFormConsultarResponsables();
        }

        private void btnConsultarViolines_Click(object sender, EventArgs e)
        {
            AbrirFormConsultarViolines();
        }

        private void btnConsultarClases_Click(object sender, EventArgs e)
        {
            AbrirFormConsultarClases();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormTiposDeConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
