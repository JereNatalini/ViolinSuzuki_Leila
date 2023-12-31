﻿using System;
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
    public partial class FormConsultarResponsables : Form
    {
        public FormTiposDeConsulta FormularioAnterior { get; set; }
        public FormConsultarResponsables()
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
        private void FormConsultarResponsables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_CONSULTAR_RESPONSABLES' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTAR_RESPONSABLESTableAdapter.Fill(this.dataSetPrincipal.SP_CONSULTAR_RESPONSABLES);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarFormularioAnterior();
        }
    }
}
