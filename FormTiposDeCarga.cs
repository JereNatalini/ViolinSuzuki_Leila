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
    public partial class FormTiposDeCarga : Form
    {
        public FormTiposDeCarga()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            FormCargarPersona formCargarPersona = new FormCargarPersona();
            formCargarPersona.Show();
        }

        private void btnViolines_Click(object sender, EventArgs e)
        {
            FormCargarViolines formCargarViolines = new FormCargarViolines();
            formCargarViolines.Show();
        }
    }
}
