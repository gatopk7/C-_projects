using System;

namespace poo
{
    class Alumno
    {
        private string nombre;
        private string apellido;
        private string codigo;
        private string carrera;
        private string semestre;

        public Alumno(string nombre, string apellido, string codigo, string carrera, string semestre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigo = codigo;
            this.carrera = carrera;
            this.semestre = semestre;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string AlumnoDatos
        {
            get { return nombre + " " + apellido + " " + codigo + " " + carrera + " " + semestre; }
        }
    }

    class Docente
    {
        private string nombre;
        private string apellido;
        private string id;
        private string materiaimparte;
        private string escuela;

        public Docente(string id, string nombre, string apellido, string materiaimparte, string escuela)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.materiaimparte = materiaimparte;
            this.escuela = escuela;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Materiaimparte
        {
            get { return materiaimparte; }
            set { materiaimparte = value; }
        }
        public string Escuela
        {
            get { return escuela; }
            set { escuela = value; }
        }
        public string DocenteDatos
        {
            get { return nombre + " " + apellido + " " + id + " " + materiaimparte + " " + escuela; }
        }

    }

    class Empleado
    {
        private string nombre;
        private string apellido;
        private string idTrabajador;
        private string empresaTrabaja;
        private string puesto;

        public Empleado(string nombre, string apellido, string idTrabajador, string empresaTrabaja, string puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idTrabajador = idTrabajador;
            this.empresaTrabaja = empresaTrabaja;
            this.puesto = puesto;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string IdTrabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }
        public string EmpresaTrabaja
        {
            get { return empresaTrabaja; }
            set { empresaTrabaja = value; }
        }
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string TrabajadorDatos
        {
            get { return nombre + " " + apellido + " " + idTrabajador + " " + empresaTrabaja + " " + puesto; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            byte op = 0;
            do
            {
                Console.WriteLine(" 0 Salir \n" +
                    " 1 Alumno \n" +
                    " 2 Docente \n" +
                    " 3 Empleado \n ");
                op = byte.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0: Console.Write("Saliendo del sistema"); break;
                    case 1: Alumno(); break;
                    case 2: Docente(); break;
                    case 3: Trabajador();  break;
                    default: Console.Write("Esa opcion no esta disponible"); break;
                }
            } while (op != 0);
        }

        private static void Alumno()
        {
            Console.Write("Creando un alumno \n");
            Console.Write("Cual es le nombre? \n");
            string n = Console.ReadLine();
            Console.Write("Cual es el apellido? \n");
            string a = Console.ReadLine();
            Console.Write("Cual es el codigo? \n");
            string c = Console.ReadLine();
            Console.Write("Cual es la carrea? \n");
            string ca = Console.ReadLine();
            Console.Write("Caual es el semestre \n");
            string s = Console.ReadLine();

            Alumno alumno1 = new Alumno(n, a, c, ca, s);
            Console.Write(alumno1.AlumnoDatos + "\n");
            Console.Write("Se ha creado con exito \n");
        }

        public static void Docente()
        {
            Console.Write("Creando un docente \n");
            Console.Write("Cual es le nombre? \n");
            string n = Console.ReadLine();
            Console.Write("Cual es el apellido? \n");
            string a = Console.ReadLine();
            Console.Write("Cual es el id? \n");
            string i = Console.ReadLine();
            Console.Write("Cual es la materia que imparte? \n");
            string m = Console.ReadLine();
            Console.Write("En cual escuela imparte clase \n");
            string e = Console.ReadLine();

            Docente docente1 = new Docente(n, a, i, m, e);
            Console.Write(docente1.DocenteDatos + "\n");
            Console.Write("Se ha creado con exito \n");
        }

        public static void Trabajador()
        {
            Console.Write("Creando un Trabajador \n");
            Console.Write("Cual es le nombre? \n");
            string n = Console.ReadLine();
            Console.Write("Cual es el apellido? \n");
            string a = Console.ReadLine();
            Console.Write("Cual es el id de trabajador? \n");
            string i = Console.ReadLine();
            Console.Write("Cual es la empreza en que trabaja? \n");
            string e = Console.ReadLine();
            Console.Write("Cual es el puesto que desenpena? \n");
            string p = Console.ReadLine();

            Empleado trabajador1 = new Empleado(n, a, i, e, p);
            Console.Write(trabajador1.TrabajadorDatos + "\n");
            Console.Write("Se ha creado con exito \n");
        }
    }
}