using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxRojo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRojo.Checked)
            {
                pnlCheckbox.BackColor = Color.FromArgb(255, 0, 0);

                if (cbxVerde.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(255, 255,0);

                    if (cbxAzul.Checked)
                    {
                        pnlCheckbox.BackColor = Color.FromArgb(255, 255,255);
                    }
                }
                else if (cbxAzul.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(255, 0, 255);
                }

            }
            else
            {
                pnlCheckbox.BackColor= Color.FromArgb(0,0,0);
                
                if(cbxVerde.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(0,255,0);

                    if(cbxAzul.Checked)
                    {
                        pnlCheckbox.BackColor = Color.FromArgb(0,255,255);
                    }
                }
                else if (cbxAzul.Checked)
                {
                    pnlCheckbox.BackColor =Color.FromArgb(0,0,255);
                }
            }
        }

        private void cbxVerde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVerde.Checked)
            {
                pnlCheckbox.BackColor = Color.FromArgb(0, 255, 0);

                if (cbxRojo.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(255, 255 , 0);

                    if (cbxAzul.Checked)
                    {
                        pnlCheckbox.BackColor = Color.FromArgb(255, 255,255);
                    }
                }
                else if (cbxAzul.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(0, 255, 255);
                }
            }
            else
            {
                pnlCheckbox.BackColor = Color.FromArgb(0, 0, 0);

                if(cbxRojo.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb (255, 0, 0);

                    if (cbxAzul.Checked)
                    {
                        pnlCheckbox.BackColor = Color.FromArgb(255, 0, 255);
                    }
                }
                else if (cbxAzul.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(0, 0, 255);
                }
            }
        }

        private void cbxAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAzul.Checked)
            {
                pnlCheckbox.BackColor = Color.FromArgb(0, 0, 255);

                if (cbxRojo.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(255, 0, 255);

                    if (cbxVerde.Checked)
                    {
                        pnlCheckbox.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
                else if (cbxVerde.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(0, 255, 255);
                }
            }
            else
            {
                pnlCheckbox.BackColor = Color.FromArgb(0, 0, 0);

                if (cbxRojo.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(255, 0, 0);

                    if (cbxVerde.Checked)
                    {
                        pnlCheckbox.BackColor = Color.FromArgb(255, 255, 0);
                    }
                }
                else if (cbxVerde.Checked)
                {
                    pnlCheckbox.BackColor = Color.FromArgb(0,255, 0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nudRojo_ValueChanged(object sender, EventArgs e)
        {
            pnlNud.BackColor = Color.FromArgb((int)nudRojo.Value, (int)nudVerde.Value, (int)nudAzul.Value);
        }

        private void nudVerde_ValueChanged(object sender, EventArgs e)
        {
            pnlNud.BackColor = Color.FromArgb((int)nudRojo.Value, (int)nudVerde.Value, (int)nudAzul.Value);
        }

        private void nudAzul_ValueChanged(object sender, EventArgs e)
        {
            pnlNud.BackColor = Color.FromArgb((int)nudRojo.Value, (int)nudVerde.Value, (int)nudAzul.Value);
        }

        private void cbxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaises.Text == "MÉXICO" )
            {
                cbxEstados.Enabled = true;
                cbxCuidades.Visible = true;

                cbxEstados.Items.Clear();
                cbxEstados.Items.Add ("CIUDAD DE MÉXICO");
                cbxEstados.Items.Add ("CHIAPAS");
                cbxEstados.Items.Add("CAMPECHE");

                cbxCuidades.Items.Clear();
                cbxCuidades.Items.Add("GUADALAJARA");
                cbxCuidades.Items.Add("MONTERREY");
                cbxCuidades.Items.Add("OAXACA");

                txt.Text = cbxPaises.Text + ", " + cbxEstados.Text + ", " + cbxCuidades.Text;


            }
            else if(cbxPaises.Text == "EUA")
            {
                cbxEstados.Enabled = true;
                cbxCuidades.Visible = true;

                cbxEstados.Items.Clear();
                cbxEstados.Items.Add("NUEVA JERSI");
                cbxEstados.Items.Add("CALIFORNIA");
                cbxEstados.Items.Add("NUEVO MÉXICO");

                cbxCuidades.Items.Clear();
                cbxCuidades.Items.Add("SAN FRANSISCO");
                cbxCuidades.Items.Add("LOS ANGELES");
                cbxCuidades.Items.Add("MIAMI");

                txt.Text = cbxPaises.Text + ", " + cbxEstados.Text + ", " + cbxCuidades.Text;

            }
            else if( cbxPaises.Text == "CANADA")
            {
                cbxEstados.Enabled = true;
                cbxCuidades.Visible = true;

                cbxEstados.Items.Clear();
                cbxEstados.Items.Add("TERRANOVA");
                cbxEstados.Items.Add("NUEVA ESCOCIA");
                cbxEstados.Items.Add("ONTARIO");

                cbxCuidades.Items.Clear();
                cbxCuidades.Items.Add("TORONTO");
                cbxCuidades.Items.Add("OTAWA");
                cbxCuidades.Items.Add("VANCOUVER");

                txt.Text = cbxPaises.Text + ", " + cbxEstados.Text + ", " + cbxCuidades.Text;
            }
        }

        private void cbxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt.Text = cbxPaises.Text + ", " + cbxEstados.Text + ", " + cbxCuidades.Text;
        }

        private void cbxCuidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt.Text = cbxPaises.Text + ", " + cbxEstados.Text + ", " + cbxCuidades.Text;
        }

        private void rbMexico_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\gatopk\\source\\repos\\Componentes\\Mexico.jpg";                
        }

        private void rbEua_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\\Users\\gatopk\\source\\repos\\Componentes\\Eua.jpg";
        }

        private void rbCanada_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"C:\\Users\\gatopk\\source\\repos\\Componentes\\Canada.jpg";
        }
    }
}
