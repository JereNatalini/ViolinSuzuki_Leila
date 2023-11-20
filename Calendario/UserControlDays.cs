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
    public partial class UserControlDays : UserControl
    {
        public string Titulo { get; set; }
        public string Desc {  get; set; }
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numDay)
        {
            lblDay.Text = numDay+"";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            FormEvento frmEvento = new FormEvento();
            frmEvento.ShowDialog();

            Titulo = frmEvento.TituloEvento;
            Desc = frmEvento.Evento;
            btnEvento.Text = Titulo;

        }

        private void btnEvento_Click(object sender, EventArgs e)
        {

            DetalleEvento frmDetalle = new DetalleEvento(Titulo,Desc);
            frmDetalle.ShowDialog();        

            

        }
    }
}
