using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GaleriaDeArte
{
    internal class Conexion
    {        
        public string conexion = "Server=localhost;user=root;password=root;port=3306;database=galeria";

        public void pruevaConexion()
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);

            try {
                mysqlConexion.Open();

            } catch (Exception ex) {
                MessageBox.Show("Error al conectarse " + ex.Message);
                return;
            }
            mysqlConexion.Close();
            MessageBox.Show("Conectado");
        }

        public void Artista(Artistas A)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "INSERT INTO `artistas` (`Nombre`, `Seudonimo`, `Telefono`, `Direccion`) VALUES ('"+ A.Name +"', '"+ A.Seudonimo +"', '"+ A.Tel1 + "', '"+ A.Direccion1 +"');";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se agrego correctamente");
        }


        public DataSet CargarArtista()
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quiery = "SELECT * FROM `artistas` LIMIT 1000;";
            MySqlDataAdapter adaptador;
            DataSet dataset = new DataSet();

            adaptador = new MySqlDataAdapter(Quiery, mysqlConexion);
            adaptador.Fill(dataset, "tbl");
            mysqlConexion.Close();
            return dataset;
        }

        public void EditarArtista(Artistas A)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "UPDATE `artistas` SET `Nombre`='"+ A.Name + "', `Seudonimo`='"+ A.Seudonimo +"', `Telefono`='"+ A.Tel1 +"', `Direccion`='"+ A.Direccion1 +"' WHERE  `Id`="+ A.Id +";";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se Actualizo correctamente");
        }

        public void BorrarArtista(Artistas A)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "DELETE FROM `artistas` WHERE  `Id`="+ A.Id +";";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se ha eliminado correctamente");
        }

        public DataSet CargarObras()
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);            

            mysqlConexion.Open();
            string Quiery = "SELECT * FROM `obras` LIMIT 1000;";
            MySqlDataAdapter adaptador;
            DataSet dataset = new DataSet();

            adaptador = new MySqlDataAdapter(Quiery, mysqlConexion);

            adaptador.Fill(dataset, "tbl");


            mysqlConexion.Close();
            return dataset;
        }


        public void AgregarObras(Obras A)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "insert into obras (Id, Precio, Titulo, Autor, Imagen) values('" + A.Id1 + "','" + A.Precio1 + "','" + A.Titulo1 + "','" + A.Autor1 + "','"+ MySql.Data.MySqlClient.MySqlHelper.EscapeString(A.Imagen) +"');";
                
            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se agrego correctamente");
        }

        public void EditarObras(Obras A)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "update `obras` SET `Id`="+A.Id1+", `Precio`= "+A.Precio1+", `Titulo`='"+A.Titulo1+"', `Autor`='"+A.Autor1+"', `Imagen` = '" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(A.Imagen) +"' WHERE  `Id`=" + A.Id1 + ";";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se Actualizo correctamente");
        }

        public void BorrarObras(Obras o)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "DELETE FROM `obras` WHERE  `Id`="+o.Id1+";";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            //MessageBox.Show("Se ha eliminado correctamente");
        }


        public DataSet Cargarclientes()
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quiery = "SELECT * FROM `clientes` LIMIT 1000;";
            MySqlDataAdapter adaptador;
            DataSet dataset = new DataSet();

            adaptador = new MySqlDataAdapter(Quiery, mysqlConexion);
            adaptador.Fill(dataset, "tbl");
            mysqlConexion.Close();
            return dataset;
        }

        public void AgregarCliente(Cliente c)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "insert into clientes(Id, Telefono, Direccion, Nombre, Usuario, Contrasena) values('" + c.IdCliente + "','" + c.Tel1 + "','" + c.Direccion1 + "','" + c.Name + "', '"+c.Usuario+"', '"+c.Contrasena+"');";


            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se agrego correctamente");
        }

        public void EditarClientes(Cliente c)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "update `clientes` SET `Id`=" + c.IdCliente + ", `Telefono`= " + c.Tel1 + ", `Direccion`='" + c.Direccion1 + "', `Nombre`='" + c.Name + "', `Usuario`='"+c.Usuario+"', `Contrasena`='"+c.Contrasena+"' WHERE  `Id`=" + c.IdCliente + ";";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se Actualizo correctamente");
        }

        public void BorrarClientes(Cliente c)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "DELETE FROM `clientes` WHERE  `Id`=" + c.IdCliente + ";";

            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se ha eliminado correctamente");
        }       

        public Cliente Exixte(Cliente c)
        {
            MySqlDataReader reader;
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();

            string Quiery = "select * from `clientes` where `Usuario` = '"+c.Usuario+"' and `Contrasena` = '"+ c.Contrasena+"';";
            MySqlCommand mysqlCommand = new MySqlCommand(Quiery, mysqlConexion);
            reader = mysqlCommand.ExecuteReader();

            Cliente f = new Cliente();

            while (reader.Read())
            {
                f.Usuario = reader["Usuario"].ToString();
                f.Contrasena = reader["Contrasena"].ToString();
                f.Name = reader["Nombre"].ToString();
                f.IdCliente = int.Parse(reader["Id"].ToString());
                f.Direccion1 = reader["Direccion"].ToString();
                f.Tel1 = int.Parse(reader["Telefono"].ToString());
            }


            return f;
        }
        public DataSet CargarVentas()
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quiery = "SELECT * FROM `ventas` LIMIT 1000;";
            MySqlDataAdapter adaptador;
            DataSet dataset = new DataSet();

            adaptador = new MySqlDataAdapter(Quiery, mysqlConexion);
            adaptador.Fill(dataset, "tbl");
            mysqlConexion.Close();
            return dataset;
        }

        public void AgregarVenta(Ticket t)
        {
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();
            string Quieriy = "insert into ventas(Id, Nombre, IdCliente, Obra, Precio, Autor, Fecha) values('"+t.IdVenta+"','"+t.Nombre+"', '"+t.IdCliente+"', '"+t.Obra1+"', '"+t.Precio1+"', '"+t.Autor1+"', current_timestamp); ";


            MySqlCommand mysqlCommand = new MySqlCommand(Quieriy, mysqlConexion);
            mysqlCommand.ExecuteNonQuery();

            mysqlConexion.Close();
            MessageBox.Show("Se agrego la venta");
        }

        public Artistas ExixteArtista(Obras c)
        {
            MySqlDataReader reader;
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();

            string Quiery = "select * from `Artistas` where `Nombre` = '" + c.Autor1 + "' || `Seudonimo` = '"+ c.Autor1 +"';";
            MySqlCommand mysqlCommand = new MySqlCommand(Quiery, mysqlConexion);
            reader = mysqlCommand.ExecuteReader();

            Artistas f = new Artistas();

            while (reader.Read())
            {                
                f.Name = reader["Nombre"].ToString();
                f.Seudonimo = reader["Seudonimo"].ToString();
                f.Id = Convert.ToInt32(reader["Id"].ToString());
            }
            return f;
        }

        public Obras BorrarArtistaConObras(Artistas c)
        {
            MySqlDataReader reader;
            MySqlConnection mysqlConexion = new MySqlConnection(conexion);
            mysqlConexion.Open();

            string Quiery = "select * from `obras` where `Autor` = '" + c.Name + "' || `Autor` = '" + c.Seudonimo + "';";
            MySqlCommand mysqlCommand = new MySqlCommand(Quiery, mysqlConexion);
            reader = mysqlCommand.ExecuteReader();

            Obras f = new Obras();

            while (reader.Read())
            {
                f.Autor1 = reader["Autor"].ToString();
                f.Titulo1 = reader["Titulo"].ToString();
                f.Id1 =  Convert.ToInt32(reader["Id"].ToString());
            }
            MessageBox.Show(f.Autor1 + f.Id1);

            return f;
        }
    }
}
