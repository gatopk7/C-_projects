using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaCurp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCURP_Click(object sender, EventArgs e)
        {
            string apellido1, apellido2, nom1, nom2, estado, sexo, anho, mes, dia,curp;

            apellido1 = txtApellido1.Text;
            apellido2 = txtApellido2.Text;
            nom1 = txtNom1.Text;
            nom2 = txtNom2.Text;
            estado = cbxEstado.SelectedItem.ToString();
            sexo = (rdbHombre.Checked)?"Hombre":"Mujer";
            anho = dtpNac.Value.Year.ToString();
            mes = dtpNac.Value.Month.ToString();
            dia = dtpNac.Value.Day.ToString();


            Persona p = new Persona();
            p.Apellido1 = apellido1;
            p.Apellido2 = apellido2;
            p.Nom1 = nom1;
            p.Nom2 = nom2;
            p.Estado = estado;
            p.Sexo = sexo;
            
            p.Anho = anho;
            p.Mes = mes;
            p.Dia = dia;

            int anio = Convert.ToInt32(anho);
            int mes1 = Convert.ToInt32(mes);
            int dias = Convert.ToInt32(dia);

            curp = p.generarCURP(apellido1, apellido2, nom1, estado, sexo, anio, mes1, dias);
            lblCurp.Text = apellido1 + " " + apellido2 + " " + nom1 + " " + nom2 + "\n" + estado + " " + sexo + " " + anho + " " + mes + " " + dia + "\n" + curp ;
        }

        private void txtApellido1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
