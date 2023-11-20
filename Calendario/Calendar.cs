using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolinSuzuki_Leila.Calendario;

namespace ViolinSuzuki_Leila
{
    public partial class Calendar : Form
    {

        int month, year;
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName.ToUpper() + " " + year;


            //Primer dia del mes
            DateTime startMonth = new DateTime(year, month, 1);

            //Cuenta de los dias
            int days = DateTime.DaysInMonth(year, month);

            int dayWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d")) + 1;

            //Blank usercontrol
            for (int i = 0; i < dayWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                
                dayContainer.Controls.Add(ucBlank);

            }

            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void btnAntes_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            //Decrementar mes

            if (month == 1)
            {
                month = 13;
                year--;
            }

            month--;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName.ToUpper() + " " + year;


            //Primer dia del mes
            DateTime startMonth = new DateTime(year, month, 1);

            //Cuenta de los dias
            int days = DateTime.DaysInMonth(year, month);

            int dayWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d")) + 1;

            //Blank usercontrol
            for (int i = 0; i < dayWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();

                dayContainer.Controls.Add(ucBlank);

            }

            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Salir del Calendario?", "Atencion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMonthYear_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            //Incrementar mes
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthYear.Text = monthName.ToUpper() + " " + year;

            //Primer dia del mes
            DateTime startMonth = new DateTime(year, month, 1);

            //Cuenta de los dias
            int days = DateTime.DaysInMonth(year, month);

            int dayWeek = Convert.ToInt32(startMonth.DayOfWeek.ToString("d")) + 1;

            //Blank usercontrol
            for (int i = 0; i < dayWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();

                dayContainer.Controls.Add(ucBlank);

            }

            //usercontrol for days
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }
    }
}
