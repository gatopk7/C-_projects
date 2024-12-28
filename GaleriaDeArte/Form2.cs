using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriaDeArte
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Artistas a = new Artistas();
            dgvDatos.DataSource = a.Cargar().Tables["tbl"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Artistas a = new Artistas();
            bool resultado;

            a.Id = (int)NUDId.Value;
            a.Name = txtNameAutor.Text;
            a.Direccion1 = txtDireccion.Text;
            a.Seudonimo = txtSeudonimo.Text;
            a.Tel1 = Convert.ToInt32(txtTel.Text);

            //artista.ValidarDatos(artista);
            resultado = a.ValidarDatos(a);

            if (resultado == false)
            {
                return;
            }

            if (a.Id == 0)
             {
               a.CrearArtista(a);

            }
            else
            {
                a.EditarArtista(a);
            }

            a.Cargar();
            dgvDatos.DataSource = a.Cargar().Tables["tbl"];
            BorrarCampos();
            
        }

        public void BorrarCampos()
        {
            NUDId.Value = 0;
            txtDireccion.Text = null;
            txtNameAutor.Text = null;
            txtSeudonimo.Text = null;
            txtTel.Text = null;
        }

        private void txtNameAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NUDId.Value = (int)dgvDatos.CurrentRow.Cells["Id"].Value;
            txtNameAutor.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDireccion.Text = dgvDatos.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTel.Text = dgvDatos.CurrentRow.Cells["Telefono"].Value.ToString();
            txtSeudonimo.Text = dgvDatos.CurrentRow.Cells["Seudonimo"].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (NUDId.Value == 0) return;

            if (MessageBox.Show("¿Deseas eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Artistas ar = new Artistas();
                ar.Autor = txtNameAutor.Text;
                ar.Seudonimo = txtSeudonimo.Text;
                ar.Name = txtNameAutor.Text;

                Obras o = new Obras();
                
                //ar.Autor = txtNameAutor.Text;
                //ar.Seudonimo = txtSeudonimo.Text;
                o = ar.BorrarArtistaConObras(ar);


                if (o.Autor1 == null)
                {
                    ar.Id = (int)NUDId.Value;
                    ar.BorrarArtista(ar);
                    ar.Cargar();
                    dgvDatos.DataSource = ar.Cargar().Tables["tbl"];
                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show("no se puede eliminar " + o.Autor1 +" porque tiene obras a su nombre");
                }
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
