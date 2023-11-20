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
    public partial class FormConsultarClases : Form
    {
        public FormConsultarClases()
        {
            InitializeComponent();
        }

        private void FormConsultarClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_CONSULTAR_PROGRESOS' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTAR_PROGRESOSTableAdapter.Fill(this.dataSetPrincipal.SP_CONSULTAR_PROGRESOS);

        }
    }
}
