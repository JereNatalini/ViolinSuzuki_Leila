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
    public partial class FormTiposDeConsulta : Form
    {
        public FormTiposDeConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultarAlumnos_Click(object sender, EventArgs e)
        {
            FormConsultarAlumnos formConsultarAlumnos = new FormConsultarAlumnos();
            formConsultarAlumnos.Show();
        }

        private void btnConsultarResponsables_Click(object sender, EventArgs e)
        {
            FormConsultarResponsables formConsultarResponsables = new FormConsultarResponsables();
            formConsultarResponsables.Show();
        }

        private void btnConsultarViolines_Click(object sender, EventArgs e)
        {
            FormConsultarViolines formConsultarViolines = new FormConsultarViolines();  
            formConsultarViolines.Show();
        }
    }
}
