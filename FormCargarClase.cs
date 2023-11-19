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
    public partial class FormCargarClase : Form
    {
        private Progreso progreso;
        private List<DetalleProgreso> lDetallesProgreso;
        Helper helper;

        public FormCargarClase(Progreso p)
        {
            helper = new Helper();
            progreso = p;
            lDetallesProgreso = new List<DetalleProgreso>();
            InitializeComponent();
        }

        private void FormCargarClase_Load(object sender, EventArgs e)
        {
            if (progreso.pResponsable != null)
            {
                lblResponsable.Text = progreso.pResponsable.Apellido.ToString() + ", " + progreso.pResponsable.Nombre.ToString();
            }
            else
            {
                lblResponsable.Text = progreso.pAlumno.Apellido.ToString() + ", " + progreso.pAlumno.Nombre.ToString();
            }
            lblAlumno.Text = progreso.pAlumno.Apellido.ToString() + ", " + progreso.pAlumno.Nombre.ToString();
            lblNClase.Text = UltimoNumeroClase().ToString();
            lblFechaHora.Text = DateTime.Now.ToString();
            
        }

        public int UltimoNumeroClase()
        {
            int? nClase = helper.ConsultarID("SP_ULTIMO_ID_PROGRESO")+1;
            if(nClase == 0 || nClase == null)
            {
                nClase = 1;
            }

            return nClase.Value;
        }

    }
}
