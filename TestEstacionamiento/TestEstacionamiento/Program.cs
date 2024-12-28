using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEstacionamiento
{
    class Carro
    {
        private string matricula;
        private string marca;
        private string color;
        private string modelo;
        private string anio;

        public int est = 0;

        public Carro()
        {}

        public Carro(string matricula, string marca, string color, string modelo, string annio)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
            this.modelo = modelo;
            this.anio = annio;
        }

        public string Matricula 
        { 
            get { return matricula; } set { matricula = value; } 
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Color
        {
            get { return color; } set { color = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public string Datos
        {
            get { return "{ matricula=" + matricula + " marca=" + marca +" color=" + color + " modelo=" + modelo + " anio=" + anio + "}"; }
        }
    }

    public static class VarEstacionamiento
    {
        public static int est=0;
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Carro[] estacionamiento = new Carro[7];
            Carro c = new Carro();

            int op = 1;

            do {
                Console.WriteLine("Seleccione una de las siguientes opciones");
                Console.WriteLine("0 salir \n1 abrir estacionamiento \n2 asignar lugar \n3 mover vehiculo \n4 cambiar datos \n5 retirar vehiculo \n6 cerrar estacionamiento");
                op=Convert.ToInt32 (Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("0 Salir");
                        break;

                    case 1:
                        Console.WriteLine("1 Abrir estacionamiento");
                        if (VarEstacionamiento.est == 0)
                        {
                            VarEstacionamiento.est = 1;
                            Console.WriteLine("Abriendo estacionamiento ");
                        }
                        else if (VarEstacionamiento.est == 1)
                        {
                            Console.WriteLine("El estacionamientno ya esta abierto ");
                        }
                        break;

                    case 2:
                        Console.WriteLine("2 Asignar lugar a vehículo");
                        if (VarEstacionamiento.est == 1)
                        {
                            int posiscion;
                            do { 
                                Console.WriteLine("En que posision se va a estacionar");
                                posiscion = Convert.ToInt32(Console.ReadLine());
                            
                                if (posiscion <= 6)
                                {
                                    if (estacionamiento[posiscion] == null)
                                    {
                                        Console.WriteLine("Cual es la matricula?");
                                        c.Matricula = Console.ReadLine();
                                        Console.WriteLine("Cual es la marca?");
                                        c.Marca = Console.ReadLine();
                                        Console.WriteLine("Cual es el color?");
                                        c.Color = Console.ReadLine();
                                        Console.WriteLine("Cuale es modelo?");
                                        c.Modelo = Console.ReadLine();
                                        Console.WriteLine("Cual es el anio?");
                                        c.Anio = Console.ReadLine();

                                        estacionamiento[posiscion] = c;
                                        Console.WriteLine("Se ha estacionado en el lugar " + posiscion + "\n corectamente");
                                        Console.WriteLine(estacionamiento[posiscion].Datos);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Lugar ocupado");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("La posicion esta fuera de lugar");
                                }
                            } while(posiscion > 7);
                            

                        }
                        else
                        {
                            Console.WriteLine("El lugar ya esta cerrado ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("3 mover vehículo de cajón");

                        if (VarEstacionamiento.est == 1)
                        {
                            Console.WriteLine("asigne una posicion");
                             int posicion = int.Parse(Console.ReadLine());
                            if (estacionamiento[posicion] != null)
                            {
                                Console.WriteLine("posicion a rrecorrer");

                                int posicion2 = int.Parse(Console.ReadLine());
                                if (estacionamiento[posicion2] != null)
                                {
                                    estacionamiento[posicion2] = c;
                                    estacionamiento[posicion] = null;
                                    Console.WriteLine("Se movio a la posiscion " + posicion2);

                                }
                                else
                                {
                                    Console.WriteLine("El lugar esta ocupado");
                                }
                            }
                            else
                            {
                                Console.WriteLine("El lugar esta vacio");
                            }
                        }


                        break;
                    case 4:
                        Console.WriteLine("4 cambiar datos del vehículo");
                        if(VarEstacionamiento.est == 1)
                        {
                            int modo = 0;
                            Console.WriteLine("Cualquier numero para salir \n1 buscar con matricula \n2 buscar por posicion");
                            modo = Convert.ToInt32(Console.ReadLine());

                            switch (modo)
                            {
                                case 1:
                                    Console.WriteLine("Cual es la matricula?");
                                    string matricula = Console.ReadLine();
                                    Console.WriteLine("En que posicion esta el vehiculo");
                                    int posicionVehiculo = int.Parse(Console.ReadLine());

                                    if (estacionamiento[posicionVehiculo].Matricula.Equals(matricula))
                                    {
                                        if (estacionamiento[posicionVehiculo] != null) {
                                            Console.WriteLine("Corecto, conteste las siguientes preguntas");

                                            Console.WriteLine("Cual es la matricula?");
                                            c.Matricula = Console.ReadLine();
                                            Console.WriteLine("Cual es la marca?");
                                            c.Marca = Console.ReadLine();
                                            Console.WriteLine("Cual es el color?");
                                            c.Color = Console.ReadLine();
                                            Console.WriteLine("Cuale es modelo?");
                                            c.Modelo = Console.ReadLine();
                                            Console.WriteLine("Cual es el anio?");
                                            c.Anio = Console.ReadLine();

                                            Console.WriteLine("Se han cambiado los datos");
                                            estacionamiento[posicionVehiculo] = c;
                                            Console.WriteLine(estacionamiento[posicionVehiculo].Datos);
                                        }
                                        else
                                        {
                                            Console.WriteLine("La posicion esta vacia");
                                        }
                                       
                                    }
                                    else
                                    {
                                        Console.WriteLine("Las matriculas no coinciden");
                                    }
                                    
                                    break;
                                case 2:

                                    Console.WriteLine("Cual es la posicion?");
                                    int posicion = int.Parse(Console.ReadLine());
                                    if (estacionamiento[posicion]!= null)
                                    {
                                        Console.WriteLine("Cual es la matricula?");
                                        c.Matricula = Console.ReadLine();
                                        Console.WriteLine("Cual es la marca?");
                                        c.Marca = Console.ReadLine();
                                        Console.WriteLine("Cual es el color?");
                                        c.Color = Console.ReadLine();
                                        Console.WriteLine("Cuale es modelo?");
                                        c.Modelo = Console.ReadLine();
                                        Console.WriteLine("Cual es el anio?");
                                        c.Anio = Console.ReadLine();

                                        Console.WriteLine("Se han cambiado los datos");
                                        Console.WriteLine(estacionamiento[posicion].Datos);
                                    }
                                    else
                                    {
                                        Console.WriteLine("El ligar esta bacio");
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("El estacionamiento esta cerrado");
                        }

                        break;
                    case 5:
                        Console.WriteLine("5 retirar vehículo");

                        if (VarEstacionamiento.est == 1)
                        {
                            Console.WriteLine("1 por matricula \n2 Por pocicion");
                            int Selecion = Convert.ToInt32(Console.ReadLine());

                            switch (Selecion)
                            {
                                case 1:
                                    if (VarEstacionamiento.est == 1)
                                    {
                                        Console.WriteLine("Cual es la matricula?");
                                        string matricula = Console.ReadLine();
                                        Console.WriteLine("En que posicion esta el vehiculo");
                                        int posicionVehiculo = int.Parse(Console.ReadLine());

                                        if (estacionamiento[posicionVehiculo].Matricula.Equals(matricula))
                                        {
                                            if (estacionamiento[posicionVehiculo] == null)
                                            {
                                                Console.WriteLine(estacionamiento[posicionVehiculo].Datos);
                                                estacionamiento[posicionVehiculo] = null;
                                                Console.WriteLine("El vehiculo se ha retirado");
                                            }
                                            else
                                            {
                                                Console.WriteLine("El lugar esta vacio");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Las matriculas no coinsiden");
                                        }

                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("En que posicion esta el vehiculo");
                                    int posicionVehiculo2 = int.Parse(Console.ReadLine());

                                    if (estacionamiento[posicionVehiculo2] != null)
                                    {
                                        Console.WriteLine(estacionamiento[posicionVehiculo2]);
                                        estacionamiento[posicionVehiculo2] = null;
                                        Console.WriteLine("vehiculo retirado exitosamente");
                                    }
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("El estacinamientno ya esta cerrado");
                        }
                            
                        break;
                    case 6:
                        Console.WriteLine("6 vaciar y cerrar estacionamiento");
                        if (VarEstacionamiento.est == 1) {

                            foreach (Carro cadena in estacionamiento)
                            {
                                if (cadena == null)
                                {
                                    Console.WriteLine("0");
                                }
                            }
                            Console.WriteLine(estacionamiento[0].Datos);
                            Console.WriteLine(estacionamiento[1].Datos);
                            Console.WriteLine(estacionamiento[2].Datos);
                            Console.WriteLine(estacionamiento[3].Datos);
                            Console.WriteLine(estacionamiento[3].Datos);
                            Console.WriteLine(estacionamiento[4].Datos);
                            Console.WriteLine(estacionamiento[5].Datos);
                            Console.WriteLine(estacionamiento[6].Datos);

                            if(VarEstacionamiento.est == 1)
                            {
                                VarEstacionamiento.est = 0;
                                Console.WriteLine("Cerado");
                            }
                            else
                            {
                                Console.WriteLine("Ya esta cerrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El estacionamiento ya esta cerrado");
                        }
                        break;

                    default:
                        Console.WriteLine("accion invalidad");
                        break;
                }
            } while (op!=0);
        }
    }
}
