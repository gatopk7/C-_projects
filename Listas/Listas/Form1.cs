using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        private Alumno a;
        private List<Alumno> Lista;
        private int posicion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            Lista=new List<Alumno>();
            MessageBox.Show("Lista creada");
            btnCrear.Enabled=false;
            btnDestruir.Enabled = true;
            btnAgregar.Enabled = true;
            btnBuscar.Enabled = true;
            //btnActualizar.Enabled = true;
            //btnRemover.Enabled = true;
            btnListar.Enabled = true;   
            btnLimpiar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo codigo está vacio");
                txtCodigo.Focus();
            }
            else if (txtNombres.Text.Trim().Length == 0)
            {
                MessageBox.Show("El campo nombres está vacio");
                txtNombres.Focus();
            }
            else
            {

                a = new Alumno();
                descargardatos();
                Lista.Add(a);
                MessageBox.Show("Alumno agregado");
                limpiar();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {            
            foreach (Alumno item in Lista)
            {
                int n = dgvAlumnos.Rows.Add();

                Console.WriteLine(item.ToString());

                dgvAlumnos.Rows[n].Cells[0].Value = item.Codigo;
                dgvAlumnos.Rows[n].Cells[1].Value = item.Nombres;
                dgvAlumnos.Rows[n].Cells[2].Value = item.Apellidos;
                dgvAlumnos.Rows[n].Cells[3].Value = item.Carrera;
                dgvAlumnos.Rows[n].Cells[4].Value = item.Grado;
            }
        }   

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigobuscado=txtCodigo.Text;
            a=new Alumno(codigobuscado);
            if (Lista.Contains(a))
            {
                posicion = Lista.IndexOf(a);
                a =Lista.ElementAt(posicion);
                cargardatos();

                btnCrear.Enabled = false;
                btnDestruir.Enabled = false;
                btnAgregar.Enabled = false;
                btnActualizar.Enabled = true;
                btnRemover.Enabled = true;
                btnListar.Enabled = false;
                txtCodigo.Enabled = false;
            }
            else
            {
                MessageBox.Show("El elemento no esta en la lista");
            }
        }

        private void cargardatos()
        {
            txtCodigo.Text = a.Codigo;
            txtNombres.Text = a.Nombres;
            txtApellidos.Text = a.Apellidos;
            txtCarrera.Text = a.Carrera;
            txtGrado.Text = a.Grado;
        }

        private void descargardatos()
        {
            a.Codigo = txtCodigo.Text.Trim().ToUpper();
            a.Nombres = txtNombres.Text.Trim().ToUpper();
            a.Apellidos = txtApellidos.Text.Trim().ToUpper();
            a.Carrera = txtCarrera.Text.Trim().ToUpper();
            a.Grado = txtGrado.Text.Trim().ToUpper();
        }

        private void limpiar()
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCarrera.Clear();
            txtGrado.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            descargardatos();
            //Lista.RemoveAt(posicion);
            //Lista.Insert(posicion, a);
            MessageBox.Show("El elemento ya fue actualizado");
            limpiar();
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnRemover.Enabled = false;
            btnListar.Enabled = true;
            txtCodigo.Enabled = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Lista.RemoveAt(posicion);
            MessageBox.Show("El elemento ya fue removido");
            limpiar();
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnRemover.Enabled = false;
            btnListar.Enabled=true;
            txtCodigo.Enabled=true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
            Lista = null;
            MessageBox.Show("La lista ha sido destruida");
            btnDestruir.Enabled = false;
            btnAgregar.Enabled=false;
            btnActualizar.Enabled=false;
            btnRemover.Enabled=false;
            btnBuscar.Enabled=false;
            btnLimpiar.Enabled=false;
            btnListar.Enabled=false;
            btnCrear.Enabled=true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnRemover.Enabled = false;
            btnListar.Enabled = true;
            txtCodigo.Enabled = true;
            limpiar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
