using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriaDeArte
{
    internal class Artistas : Persona
    {
        private int id;
        private string seudonimo;
        private string autor;

        public string Seudonimo { get => seudonimo; set => seudonimo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Id { get => id; set => id = value; }


        public Artistas()
        {
        }

        public Artistas(int id, string seudonimo, string autor)
        {
            this.id = id;
            this.seudonimo = seudonimo;
            this.autor = name;
        }

        public bool ValidarDatos(Artistas a)
        {
            bool auxbool = true;

            if (Convert.ToString(a.Tel1) == string.Empty) {

                auxbool = false;
                MessageBox.Show("El télefono es obligatorio");
            }
            if(a.Seudonimo == String.Empty)
            {
                auxbool = false ;
                MessageBox.Show("El seudónimo es obligatorio");
            }
            if (a.Direccion == String.Empty)
            {
                auxbool = false;
                MessageBox.Show("La dirección es obligatoria");
            }
            if (a.name == String.Empty)
            {
                auxbool = false;
                MessageBox.Show("El nombre es obligatorio");
            }
            return auxbool;
        }
        Conexion mysql = new Conexion();
        public void pruevaConexion()
        {            
            mysql.pruevaConexion();            
        }

        public void CrearArtista(Artistas a)
        {
            mysql.Artista(a);
        }

        public DataSet Cargar()
        {
            return mysql.CargarArtista();
        }

        public void EditarArtista(Artistas a)
        {
            Conexion mysql = new Conexion();

            mysql.EditarArtista(a);
        }

        public void BorrarArtista(Artistas a)
        {
            Conexion mysql = new Conexion();

            mysql.BorrarArtista(a);
        }

        public Artistas anadirObra(Obras a)
        {
            Conexion mysql = new Conexion();
            return mysql.ExixteArtista(a);            
        }

        public Obras BorrarArtistaConObras(Artistas s)
        {
            Conexion mysql = new Conexion();
            return mysql.BorrarArtistaConObras(s);
        }
    }
}
