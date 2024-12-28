using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custioniario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Nombre;
        public static string Apellidos;
        private static string Carrera;
        private static int semestre;
        public static int calificacion;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombres.Text;
            Apellidos = txtApelkidos.Text;
            Carrera = txtCarrera.Text;
            semestre = Convert.ToInt32(txtSemestre.Text);

            txtNombres.Text = "";
            txtApelkidos.Text = "";
            txtCarrera.Text = "";
            txtSemestre.Text = "";

            panel1.Visible = true;
            Form Preguntas = new Form2();
            Preguntas.Visible = true;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApelkidos.Text = "";
            txtCarrera.Text = "";
            txtSemestre.Text = "";
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApelkidos.Text = "";
            txtCarrera.Text = "";
            txtSemestre.Text = "";
        }
    }
}
