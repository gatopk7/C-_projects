using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriaDeArte
{
    internal class Cliente: Persona
    {
        private int idCliente;
        private string usuario;
        private string contrasena;


        public Cliente()
        {
        }

        public Cliente(string name, string direccion, int tel, int idCliente, string usuario, string contrasena) : base(name, direccion, tel)
        {            
            base.Direccion = direccion;
            base.Tel = tel;
            base.Name = name;
            this.IdCliente = idCliente;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public bool ValidarDatos(Cliente c)
        {
            bool auxbool = true;

            if (Convert.ToString(c.Tel1) == string.Empty)
            {

                auxbool = false;
                MessageBox.Show("El télefono es obligatorio");
            }
            if (c.Direccion1 == string.Empty)
            {
                auxbool = false;
                MessageBox.Show("La dirección es obligatoria");
            }
            if (Convert.ToString(c.idCliente) == string.Empty)
            {
                auxbool = false;
                MessageBox.Show("El id es obligatorio");
            }
            if (c.name == string.Empty)
            {
                auxbool = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            if (c.usuario == string.Empty)
            {
                auxbool = false;
                MessageBox.Show("El usuario es obligatorio");
            }
            if (c.Contrasena == string.Empty)
            {
                auxbool = false;
                MessageBox.Show("La contraseña es obligatoria");
            }

            return auxbool;
        }

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            bool aux = true;
            Cliente g = new Cliente();
            g.usuario = usuario;
            g.contrasena = contrasena;
            g = mysql.Exixte(g);


            if (string.IsNullOrEmpty(Cliente.txtusuario))
            {
                MessageBox.Show("El usuario es obligatorio");
                aux = false;
            }
            if (string.IsNullOrEmpty(Cliente.txcontrasena))
            {
                MessageBox.Show("La contraseña es obligatoria");
                aux = false;
            }
            else
            {
                if (g == null)
                {
                    MessageBox.Show("El usuario no existe");
                    aux = false;
                }
                else
                {
                    if(g.contrasena != contrasena)
                    {
                        MessageBox.Show("El usuario o contraseña no coinsiden");
                        aux = false;
                    }
                }
            }

            return aux;
        }

        public static string txtusuario;
        public static string txcontrasena;
        public static bool aux = false;
        public static string nameSaludo;
        public static Form1 f1 = new Form1();

        public Cliente usuarios (Cliente f)
        {
            return mysql.Exixte(f);         
        }   

        Conexion mysql = new Conexion();

        public DataSet cargarClientes()
        {
            return mysql.Cargarclientes();
        }

        public void AgregarCliente(Cliente c)
        {
            mysql.AgregarCliente(c);
        }

        public void EditarCliente(Cliente c)
        {
            mysql.EditarClientes(c);
        }

        public void BorrarClientes(Cliente c)
        {
            mysql.BorrarClientes(c);
        }

        public void Prueva()
        {
            mysql.pruevaConexion();
        }
    }
}
