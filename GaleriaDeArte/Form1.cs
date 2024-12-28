using System;
using System.Windows.Forms;

namespace GaleriaDeArte
{
    public partial class Form1 : Form
    {

        //eduardo Alvarado Gutierrez
        //Christian Uriel Gómez Martinez

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Obras c = new Obras();
            DGVDatos.DataSource = c.CargarObras().Tables["tbl"];

            lblBienvenida.Text = "Bienvenido " + Cliente.nameSaludo;

            if(Cliente.aux == false )
            {
                artistasToolStripMenuItem.Enabled = false;
                obrasToolStripMenuItem1.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = false;
                //ticketsToolStripMenuItem.Enabled = false;
            }
            else
            {
                artistasToolStripMenuItem.Enabled = true;
                obrasToolStripMenuItem1.Enabled = true;
                clientesToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
                //ticketsToolStripMenuItem.Enabled = true;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Visible = true;            
        }

        private void artistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
        }

        private void obrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Visible = true;
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Obras o = new Obras();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            o.Id1 = (int)DGVDatos.CurrentRow.Cells["Id"].Value;
            o.Precio1 = (int)DGVDatos.CurrentRow.Cells["Precio"].Value;
            o.Autor1 = DGVDatos.CurrentRow.Cells["Autor"].Value.ToString();
            o.Titulo1 = DGVDatos.CurrentRow.Cells["Titulo"].Value.ToString();
            o.Imagen = DGVDatos.CurrentRow.Cells["Imagen"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo.Visible = false;           
            btnComprar2.Visible = true;
            btnComprar2.Enabled = true;
            DGVDatos.Visible = true;

            Text = "Obras";
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logo.Visible = true;
            btnComprar2.Visible = false;
            btnComprar2.Enabled = false;
            DGVDatos.Visible = false;

            Text = "Nueva hoja";
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
        }

        private void DGVDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Obras o = new Obras();

            o.Id1 = (int)DGVDatos.CurrentRow.Cells["idobras"].Value;
            o.Precio1 = (int)DGVDatos.CurrentRow.Cells["Precio"].Value;
            o.Autor1 = DGVDatos.CurrentRow.Cells["Autor"].Value.ToString();
            o.Titulo1 = DGVDatos.CurrentRow.Cells["Titulo"].Value.ToString();
            o.Imagen = DGVDatos.CurrentRow.Cells["Imagen"].Value.ToString();

            Cliente f = new Cliente();
            f.Usuario = Cliente.txtusuario;
            f.Contrasena = Cliente.txcontrasena;

            Cliente aux = new Cliente();

            aux = f.usuarios(f);

            if (f != null)
            {
                if (MessageBox.Show("¿Deseas Comprar "+o.Titulo1 + " a un precio de "+ o.Precio1+"?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Ticket t = new Ticket();
                    t.IdVenta = 0;
                    t.Nombre = aux.Name;
                    t.IdCliente = aux.IdCliente;
                    t.Obra1 = o.Titulo1;
                    t.Precio1 = o.Precio1;
                    t.Autor1 = o.Autor1;

                    t.AgregarVenta(t);                       

                    MessageBox.Show(t.Datos());
                }
            }*/

        }

        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            if (o != null)
            {
                if (MessageBox.Show("¿Deseas Comprar " + o.Titulo1 + " a un precio de " + o.Precio1 + "?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente aux = new Cliente();
                    Cliente f = new Cliente();
                    Ticket t = new Ticket();

                    f.Usuario = Cliente.txtusuario;
                    f.Contrasena = Cliente.txcontrasena;
                    aux = f.usuarios(f);

                    t.IdVenta = 0;
                    t.Nombre = aux.Name;
                    t.IdCliente = aux.IdCliente;
                    t.Obra1 = o.Titulo1;
                    t.Precio1 = o.Precio1;
                    t.Autor1 = o.Autor1;
                    t.Fecha = DateTime.Now.Date;

                    t.AgregarVenta(t);

                    MessageBox.Show(t.Datos());

                    o.BorrarObras(o);

                    DGVDatos.DataSource = o.CargarObras().Tables["tbl"];
                    o = null;

                }
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Visible = true;
        }
    }
}