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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void cargarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargarPersona formCargarPersona = new FormCargarPersona();
            formCargarPersona.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReporte report = new FormReporte();
            report.Show();
        }
    }
}
