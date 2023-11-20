using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViolinSuzuki_Leila.Calendario
{
    public partial class DetalleEvento : Form
    {
        public string Titulo { get; set; }
        public string Desc { get; set; }
        public DetalleEvento(string titulo, string descripcion)
        {
            InitializeComponent();
            Titulo = titulo;
            Desc = descripcion;

        }

        private void DetalleEvento_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = Titulo;
            lblDesc.Text = Desc;
        }
    }
}
