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

    public partial class FormListarAlumnosClases : Form
    {
        private FormListarResponsablesClases formResponsables;

        public FormListarAlumnosClases()
        {
            InitializeComponent();
        }

        private void FormListarAlumnosClases_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal1.SP_LISTAR_ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.sP_LISTAR_ALUMNOSTableAdapter.Fill(this.dataSetPrincipal1.SP_LISTAR_ALUMNOS);
            btnSeleccionar.Text = "Seleccionar";


        }
        private void AbrirFormListarResponsables(Alumno a)
        {
            formResponsables = new FormListarResponsablesClases(a);
            formResponsables.FormularioAnterior = this; // Establecer referencia al formulario anterior
            formResponsables.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Alumno alumno = new Alumno();

            if (dgvAlumnos.CurrentCell.ColumnIndex == 4)
            {
                DataGridViewRow filaSeleccionada = dgvAlumnos.Rows[e.RowIndex];
                alumno.IdAlumno = (int)filaSeleccionada.Cells[0].Value;
                alumno.Nombre = filaSeleccionada.Cells[1].Value.ToString();
                alumno.Apellido = filaSeleccionada.Cells[2].Value.ToString();
                AbrirFormListarResponsables(alumno);
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
