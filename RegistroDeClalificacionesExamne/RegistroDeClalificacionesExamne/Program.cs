using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Eduardo Alvarado Gutierrez

namespace RegistroDeClalificacionesExamne
{
    internal class Program
    {
        public static void Menu()
        {
            int op;
            do { 
            
            
                Console.WriteLine("********************************************");
                Console.WriteLine("                   Menu");
                Console.WriteLine("Seleccione una de las siguientes opciones\n" +
                    "\n0 Salir\n" +
                    "1 Docentes\n" +
                    "2 Alumnos\n" +
                    "3 Clases\n" +
                    "4 Calificaciones\n");
                Console.WriteLine("**********************************************");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Saliendo de sistema");
                        break;
                    case 1:
                        ManuDocente();
                        break;
                    case 2:
                        MenuAlumnos();
                        break;
                    case 3:
                        MenuClases();
                        break;
                    case 4:
                        MenuCalificaciones();
                        break;
                    default:
                        Console.WriteLine("Esa opcion no esta en la lista");
                        break;
                }
            } while (op != 0);
        }

        public static void ManuDocente()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("                Menu Docente");
            Console.WriteLine("Seleccione una de las siguientes opciones\n" +
                "\n0 Regresar\n" +
                "1 Crear lista de docentes\n" +
                "2 Agregar 1 docente\n" +
                "3 Editar\n" +
                "4 Remover\n" +
                "5 Vaciar lista\n" +
                "6 Destruir Lista");
            Console.WriteLine("**********************************************");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.WriteLine("crear lista de docentes");
                    Lsita.CrearLista();
                    break;
                case 2:
                    Console.WriteLine("Agregar 1 docente");
                    if (Lsita.docente1[0] != null) 
                    {
                        Lsita.agregar();
                    }
                    else
                    {
                        Console.WriteLine("Necesita crear la lista de docentes");
                    }
                    break;
                case 3:
                    Console.WriteLine("Editar");
                    if (Lsita.docente1[0] != null)
                    {
                        Console.WriteLine("****************************************");
                        string id;
                        Console.WriteLine("Cual es id");
                        id= Console.ReadLine();
                        Lsita.Editar(id);
                        Console.WriteLine("****************************************");
                    }
                    else
                    {
                        Console.WriteLine("Necesita crear la lista de docentes");
                    }

                    break;
                case 4:
                    Console.WriteLine("Remover");
                    if(Lsita.docente1[0] != null)
                    {
                        Console.WriteLine("****************************************");
                        Console.WriteLine("Cual es el id ");
                        string id = Console.ReadLine();
                        Lsita.Remover(id);
                        Console.WriteLine("****************************************");
                    }
                    else
                    {
                        Console.WriteLine("Primero debe crear la lista");
                    }
                    break;
                case 5:
                    Console.WriteLine("Vaciar lista");
                    if (Lsita.docente1[0] != null)
                    {
                        Lsita.Vaciar();
                    }
                    else
                    {
                        Console.WriteLine("Primero debe crear la lista");
                    }
                    break;
                case 6:
                    Console.WriteLine("destruir lista");
                    if(Lsita.docente1[0] != null)
                    {
                        Lsita.DestruirLista();
                    }
                    else
                    {
                        Console.WriteLine("Peimero debe de crear la lista");
                    }
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta en la lista");
                    break;
            }
        }

        public static void MenuAlumnos()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("                Menu Alumno");
            Console.WriteLine("Seleccione una de las siguientes opciones\n" +
                "\n0 Regresar\n" +
                "1 Crear lista de alumnos\n" +
                "2 Agregar 1 alumno\n" +
                "3 Editar\n" +
                "4 Remover\n" +
                "5 Vaciar lista\n" +
                "6 Destruir lista");
            Console.WriteLine("**********************************************");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.WriteLine(" Crear lista de alumnos");
                    LsitaAlumno.CrearLista();
                    break;
                case 2:
                    Console.WriteLine("Agregar 1 alumno");
                    if(LsitaAlumno.Alumno1[0] != null)
                    {
                        LsitaAlumno.agregar();
                    }
                    else
                    {
                        Console.WriteLine("Primero crea la lista");
                    }
                    break;
                case 3:
                    Console.WriteLine("Editar");
                    if (LsitaAlumno.Alumno1[0] != null)
                    {
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Cual es el codigo");
                        string codigo = Console.ReadLine();
                        LsitaAlumno.Editar(codigo);
                        Console.WriteLine("**************************************");
                    }
                    else
                    {
                        Console.WriteLine("Primero crea la lista");
                    }
                    break;
                case 4:
                    Console.WriteLine("Remover");
                    if (LsitaAlumno.Alumno1[0] != null)
                    {
                        Console.WriteLine("**************************************");
                        Console.WriteLine("Cual es el codigo");
                        string codigo = Console.ReadLine();
                        LsitaAlumno.Remover(codigo);
                        Console.WriteLine("**************************************");
                    }
                    else
                    {
                        Console.WriteLine("Primero crea la lista");
                    }                    

                    break;
                case 5:
                    Console.WriteLine("Vaciar lista");
                    if (LsitaAlumno.Alumno1[0] != null)
                    {
                        LsitaAlumno.Vaciar();
                    }
                    else
                    {
                        Console.WriteLine("Primero crea la lista");
                    }
                    break;
                case 6:
                    Console.WriteLine("Destruir lista");
                    if (LsitaAlumno.Alumno1[0] != null)
                    {
                        LsitaAlumno.DestruirLista();
                    }
                    else
                    {
                        Console.WriteLine("Primero crea la lista");
                    }
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta en la lista");
                    break;
            }
        }

        public static void MenuClases()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("                    Clases");
            Console.WriteLine("Seleccione una de las siguientes opciones\n" +
                "\n0 Regresar\n" +
                "1 Crear lista de Clases\n" +
                "2 Agregar 1 Clase\n");
            Console.WriteLine("**********************************************");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.WriteLine("Crear lista de Clases");
                    lsitaClase.Lista();
                    break;
                case 2:
                    Console.WriteLine("Agregar 1 Clase");
                    if (lsitaClase.clase[0] != null && LsitaAlumno.Alumno1[0] != null && Lsita.docente1[0] != null)
                    {
                        lsitaClase.Agregar();
                    }
                    else
                    {
                        Console.WriteLine("Primero debe crear la lista, docentes y alumnos");
                    }
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta en la lista");
                    break;
            }

        }

        public static void MenuCalificaciones()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("                Calificaciones");
            Console.WriteLine("Seleccione una de las siguientes opciones\n" +
                "\n0 Regresar\n" +
                "1 Capturar Calificaciones");
            Console.WriteLine("**********************************************");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.WriteLine("Capturar Calificaciones");
                    if(LsitaAlumno.Alumno1[0] != null && Lsita.docente1[0] != null && lsitaClase.clase[0] != null)
                    {
                    Console.WriteLine("*******************************");
                        LsitaCalificaciones.Reset();
                        Console.Write("Cual es el codigo de la clase ");
                        string cod =Console.ReadLine();
                        LsitaCalificaciones.RegistrarCalificaion(cod);
                    Console.WriteLine("*******************************");
                    }
                    else
                    {
                        Console.WriteLine("Primero crea docentes, alumnos y clase");
                    }
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta en la lista");
                    break;
            }
        }

        public class Persona
        {
            private string Nombre;
            private string Apellido;
            private string curp;
            private bool Estatus = false;

            public Persona() { }

            public Persona(string nombre, string apellido, string curp)
            {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.curp = curp;
            }

            public string Nombre1 { get => Nombre; set => Nombre = value; }
            public string Apellido1 { get => Apellido; set => Apellido = value; }
            public string Curp { get => curp; set => curp = value; }
            public bool Estatus1 { get => Estatus; set => Estatus = value; }

            public override bool Equals(object obj)
            {
                return obj is Persona persona &&
                       Nombre == persona.Nombre &&
                       Apellido == persona.Apellido &&
                       curp == persona.curp;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public class Alumno : Persona
        {
            private string codigo;
            private string turno;
            private string semestre;
            private int Clalificacion;

            public Alumno(string nombre, string apellido, string codigo, string turno, string semestre, int calificacion)
            {
                this.Clalificacion2 = calificacion;
                this.Codigo1 = codigo;
                this.Turno1 = turno;
                this.Semestre1 = semestre;
            }

            public Alumno(string nombre, string apellido, string curp, string codigo, string turno, string semestre) : base(nombre, apellido, curp)
            {
                this.Codigo1 = codigo;
                this.Turno1 = turno;
                this.Semestre1 = semestre;
            }

            public Alumno() { }

            public Alumno(string curp)
            {
                this.Curp = curp;
            }

            public Alumno(string nombre, string apellido, string codigo, string turno, string semestre)
            {

                this.Codigo1 = codigo;
                this.Turno1 = turno;
                this.Semestre1 = semestre;
            }

            public string AlumnoDatos { get => "{" + " Nombre=" + Nombre1 +" Apellido=" + Apellido1 + " Codigo=" + Codigo1 + " Turno=" + Turno1 + " Semestre=" + Semestre1 + " Estatus=" + Estatus1 + "}";}

            public string Codigo { get => Codigo; set => Codigo = value; }
            public string Turno { get => Turno; set => Turno = value; }
            public string Semestre { get => Semestre; set => Semestre = value; }
            public string Codigo1 { get => codigo; set => codigo = value; }
            public string Turno1 { get => turno; set => turno = value; }
            public string Semestre1 { get => semestre; set => semestre = value; }
            public int Clalificacion1 { get => Clalificacion2; set => Clalificacion2 = value; }
            public int Clalificacion2 { get => Clalificacion; set => Clalificacion = value; }

            public override bool Equals(object obj)
            {
                return obj is Alumno alumno &&
                       base.Equals(obj) &&
                       Turno == alumno.Turno &&
                       Semestre == alumno.Semestre;
            }

            public override int GetHashCode()
            {
                int hashCode = 166347624;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Turno);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Semestre);
                return hashCode;
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public class Docente : Persona
        {
            private string Id;
            private string Escuela;
            private string Materia;

            public string Id1 { get => Id; set => Id = value; }
            public string Escuela1 { get => Escuela; set => Escuela = value; }
            public string Materia1 { get => Materia; set => Materia = value; }

            public string DocenteDatos { get => "{" + " Nomre="+ Nombre1 + " Apellido="+ Apellido1 +" Id="+Id + " Escuela=" + Escuela + " Materia=" + Materia + " Estatus=" + Estatus1 + " }";}

            public Docente() { }

            public Docente(string nombre, string apellido, string curp, string Id, string Escuela, string Materia) : base(nombre, apellido, curp)
            {
                this.Id = Id;
                this.Escuela = Escuela;
                this.Materia = Materia;
                this.Estatus1 = true;
            }

            public Docente(string nombre, string apellido, string id, string escuela, string materia)
            {
                this.Nombre1 = nombre;
                this.Apellido1 = apellido;
                this.Id = id;
                this.Escuela = escuela;
                this.Materia = materia;
                this.Estatus1 = true;
            }

            public Docente(string id)
            {
                Id = id;
            }


            public override bool Equals(object obj)
            {
                return obj is Docente docente &&
                       base.Equals(obj) &&
                       Id == docente.Id &&
                       Escuela == docente.Escuela;
            }

            public override int GetHashCode()
            {
                int hashCode = 46567619;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Escuela);
                return hashCode;
            }
        }

        public class Clases
        {
            private string Clave;
            private string Nombre;
            private Clases[] clases;
            private Alumno[] alumnos;
            public Docente[] docentes;

            public Clases(string clave, string nombre)
            {
                Clave = clave;
                Nombre = nombre;
            }

            public Clases() { }            
            public string ClaseDatos { get => "{" + " Clave=" + Clave1 + " Clase=" + Nombre + " }"; }

            public string Clave1 { get => Clave; set => Clave = value; }
            public string Clave2 { get => Clave; set => Clave = value; }
            internal Clases[] Clasess { get => clases; set => clases = value; }
            internal Alumno[] Alumnos { get => alumnos; set => alumnos = value; }
            internal Docente[] Docentes { get => docentes; set => docentes = value; }
            internal Clases[] Clases1 { get => clases; set => clases = value; }
            internal Alumno[] Alumnos1 { get => alumnos; set => alumnos = value; }
            internal Docente[] Docentes1 { get => docentes; set => docentes = value; }
            public string Nombre1 { get => Nombre; set => Nombre = value; }

            public override bool Equals(object obj)
            {
                return obj is Clases clase &&
                       Clave == clase.Clave &&
                       EqualityComparer<Clases[]>.Default.Equals(clases, clase.clases) &&
                       EqualityComparer<Alumno[]>.Default.Equals(alumnos, clase.alumnos) &&
                       EqualityComparer<Docente[]>.Default.Equals(docentes, clase.docentes);
                      // EqualityComparer<string[]>.Default.Equals(calificaciones, clase.calificaciones);
            }

            public override int GetHashCode()
            {
                int hashCode = 415877612;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Clave);
                hashCode = hashCode * -1521134295 + EqualityComparer<Clases[]>.Default.GetHashCode(clases);
                hashCode = hashCode * -1521134295 + EqualityComparer<Alumno[]>.Default.GetHashCode(alumnos);
                hashCode = hashCode * -1521134295 + EqualityComparer<Docente[]>.Default.GetHashCode(docentes);
                return hashCode;
            }
        }

        public static class Lsita
        {
            //Docente
            public static Docente[] docente1 = new Docente[10];

            public static void CrearLista()
            {
                Docente g = new Docente();
                for (int i = 0; i < docente1.Length; i++)
                {
                    docente1[i] = g;
                }
                Console.WriteLine("Se ha creado la lista");
            }

            public static void agregar()
            {
                int op = 0;

                Console.WriteLine("**********************************");
                Console.WriteLine("Agregando un docente");
                Docente f = new Docente();

                Console.Write("Nombre ");
                f.Nombre1 = Console.ReadLine();
                Console.Write("Apellido ");
                f.Apellido1 = Console.ReadLine();
                Console.Write("Id ");
                f.Id1 = Console.ReadLine();
                Console.Write("Escula ");
                f.Escuela1 = Console.ReadLine();
                Console.Write("Materia ");
                f.Materia1 = Console.ReadLine();

                Console.WriteLine("en que posicion");
                string s = Console.ReadLine();
                op = Convert.ToInt32(s);

                bool d = false;
                for(int i = 0;i < docente1.Length; i++)
                {
                    if(docente1[i].Id1 == f.Id1)
                    {
                        d = true;
                    }
                }
                if (d == false)
                {
                    docente1[op] = f;
                    Console.Write("Se ha agregado ");
                    Console.WriteLine(docente1[op].DocenteDatos);
                }
                else
                {
                    Console.WriteLine("El id ya existe");
                }
                
                Console.WriteLine("**********************************");
            }

            public static void Editar(string id)
            {
                for(int i = 0; i < docente1.Length; i++)
                {
                    if(docente1[i].Id1 == id)
                    {
                        Docente f = new Docente();

                        Console.WriteLine("****************************************");
                        Console.Write("Nombre ");
                        f.Nombre1 = Console.ReadLine();
                        Console.Write("Apellido ");
                        f.Apellido1 = Console.ReadLine();
                        f.Id1 = id;
                        Console.Write("Escula ");
                        f.Escuela1 = Console.ReadLine();
                        Console.Write("Materia ");
                        f.Materia1 = Console.ReadLine();

                        docente1[i] = f;
                        Console.Write("Se ha modificado ");
                        Console.WriteLine(docente1[i].DocenteDatos);
                        Console.WriteLine("****************************************");

                    }
                }
            }

            public static void Remover(string id)
            {
                for(int i=0; i < docente1.Length; i++)
                {
                    if(docente1[i].Id1 == id)
                    {

                        Console.WriteLine("*********************************");
                        Console.WriteLine(docente1[i].DocenteDatos);
                        Console.WriteLine("Se ha removido correctamente");
                        docente1[i] = null;
                        Console.WriteLine("*********************************");

                    }
                }
            }

            public static void Vaciar()
            {
                Console.WriteLine("****************************************");
                Docente g = new Docente();
                for(int i=0; i < docente1.Length; i++)
                {
                    if (docente1[i].Estatus1 != true)
                    {
                            Console.WriteLine(docente1[i].DocenteDatos);
                            docente1[i] = g;

                    }
                }

                Console.WriteLine("Se han vaciado los datos");
                Console.WriteLine("****************************************");
            }

            public static void DestruirLista()
            {
                bool estado = false;
                for (int i = 0; i < docente1.Length; i++)
                {
                    if (docente1[i].Estatus1 == true)
                    {
                        estado = true;
                    }
                }

                if (estado == false)
                {
                    for (int i = 0; i < docente1.Length; i++)
                    {
                        Console.WriteLine(docente1[i].DocenteDatos);
                        docente1[i] = null;
                    }
                    Console.WriteLine("****************************************");
                    Console.WriteLine("Se ha destruido la lista");
                    Console.WriteLine("****************************************");
                }
                else
                {
                    Console.WriteLine("Hay docentes activos");
                }
                
            }
        }

        public static class LsitaAlumno
        {
            //Alumno
            public static Alumno[] Alumno1 = new Alumno[10];

            public static void CrearLista()
            {
                Alumno g = new Alumno();
                for (int i = 0; i < Alumno1.Length; i++)
                {
                    Alumno1[i] = g;
                }
                Console.WriteLine("Se ha creado la lista");
            }

            public static void agregar()
            {
                int op = 0;

                Console.WriteLine("**********************************");
                Console.WriteLine("Agregando un docente");
                Alumno f = new Alumno();

                Console.Write("Nombre ");
                f.Nombre1 = Console.ReadLine();
                Console.Write("Apellido ");
                f.Apellido1 = Console.ReadLine();
                Console.Write("Codigo ");
                f.Codigo1 = Console.ReadLine();
                Console.Write("Turno ");
                f.Turno1 = Console.ReadLine();
                Console.Write("semestre ");
                f.Semestre1 = Console.ReadLine();

                Console.WriteLine("en que posicion");
                string s = Console.ReadLine();
                op = Convert.ToInt32(s);

                bool d = false;
                for (int i = 0; i < Alumno1.Length; i++)
                {
                    if (Alumno1[i].Codigo1 == f.Codigo1)
                    {
                        d = true;
                    }
                }
                if (d == false)
                {
                    Alumno1[op] = f;
                    Console.Write("Se ha agregado ");
                    Console.WriteLine(Alumno1[op].AlumnoDatos);
                }
                else
                {
                    Console.WriteLine("El codigo ya existe");
                }

                Console.WriteLine("**********************************");
            }

            public static void Editar(string codigo)
            {
                for (int i = 0; i < Alumno1.Length; i++)
                {
                    if (Alumno1[i].Codigo1 == codigo)
                    {
                        Alumno f = new Alumno();

                        Console.WriteLine("****************************************");
                        Console.Write("Nombre ");
                        f.Nombre1 = Console.ReadLine();
                        Console.Write("Apellido ");
                        f.Apellido1 = Console.ReadLine();
                        f.Codigo1 = codigo;
                        Console.Write("Turno ");
                        f.Turno1 = Console.ReadLine();
                        Console.Write("semestre ");
                        f.Semestre1 = Console.ReadLine();

                        Alumno1[i] = f;
                        Console.Write("Se ha modificado ");
                        Console.WriteLine(Alumno1[i].AlumnoDatos);
                        Console.WriteLine("****************************************");

                    }
                }
            }

            public static void Remover(string id)
            {
                for (int i = 0; i < Alumno1.Length; i++)
                {
                    if (Alumno1[i].Codigo1 == id)
                    {
                        Console.WriteLine("*********************************");
                        Console.WriteLine(Alumno1[i].AlumnoDatos);
                        Console.WriteLine("Se ha removido correctamente");
                        Alumno1[i] = null;
                        Console.WriteLine("*********************************");
                    }
                }
            }

            public static void Vaciar()
            {
                Alumno g = new Alumno();
                for (int i = 0; i < Alumno1.Length; i++)
                {
                    if (Alumno1[i].Estatus1 != true)
                    {
                        Console.WriteLine(Alumno1[i].AlumnoDatos);
                        Alumno1[i] = g;
                    }
                }
                Console.WriteLine("****************************************");
                Console.WriteLine("Se borraron los alumnos inactivos");
                Console.WriteLine("****************************************");
            }

            public static void DestruirLista()
            {
                bool estado = false;
                for (int i = 0; i < Alumno1.Length; i++)
                {
                    if (Alumno1[i].Estatus1 == true)
                    {
                        estado = true;
                    }
                }

                if(estado == false)
                {
                    for (int i = 0; i < Alumno1.Length; i++)
                    {
                        Console.WriteLine(Alumno1[i].AlumnoDatos);
                        Alumno1[i] = null;
                    }
                    Console.WriteLine("****************************************");
                    Console.WriteLine("Se ha destruido la lista");
                    Console.WriteLine("****************************************");
                }
                else
                {
                    Console.WriteLine("****************************************");
                    Console.WriteLine("Hay alumnos activos");
                    Console.WriteLine("****************************************");
                }
            }
        }

        public class lsitaClase
        {
            // Clases
            public static Clases[] clase = new Clases[10];
            public static string[] p = new string[10];
            public static string [] doc = new string[10];

            public static void Lista()
            {
                Clases g = new Clases();
                for (int i = 0;i < clase.Length; i++)
                {
                    clase[i] = g;
                }
            }

            public static void Agregar()
            {
                Clases f = new Clases();
                Console.WriteLine("************************************");
                Console.Write("Codigo de la calse ");
                f.Clave1 = Console.ReadLine();
                Console.Write("Cual es el nombre de la clase ");
                f.Nombre1 = Console.ReadLine();
                Console.Write("En que posicion ");
                int d = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("id de docente ");
                string idcodig = Console.ReadLine();

                for(int i = 0; i < Lsita.docente1.Length; i++)
                {
                    if(Lsita.docente1[i].Id1 == idcodig)
                    {
                        doc[i] = idcodig;
                        Lsita.docente1[i].Estatus1 = true;
                    }
                }

                bool s = false;
                for (int i = 0; i < clase.Length; i++)
                {
                    if (clase[i].Clave1 == f.Clave1)
                    {
                        s = true;
                        Console.WriteLine("La clave ya existe");
                    }
                }
                if (s == false)
                {
                    string c;
                    int i = 1;
                    while (i == 1)
                    {
                        Console.WriteLine("Codigo del alumno a agregar");
                        c = Console.ReadLine();

                        for (int e = 0; e < LsitaAlumno.Alumno1.Length; e++)
                        {
                            if (LsitaAlumno.Alumno1[e].Codigo1 == c)
                            {
                                clase[d] = f;
                                p[d] = c;
                                LsitaAlumno.Alumno1[e].Estatus1 = true;
                                Console.Write("Se ha gurdado");
                                Console.WriteLine(clase[d].ClaseDatos + LsitaAlumno.Alumno1[e].AlumnoDatos);
                            }
                        }
                        Console.WriteLine("Quieres añadir otro alumno \n1 si 0 no");
                        i = Convert.ToInt32(Console.ReadLine());
                    }
                }   
                Console.WriteLine("************************************");
            }
        }

        public class LsitaCalificaciones
        {
            public static int[] calificaciones = new int[10];

            public static void Reset()
            {
                for(int i = 0;i < calificaciones.Length; i++)
                {
                    calificaciones[i] = 0;
                }
            }

            public static void RegistrarCalificaion(string CodigoClase)
            {
                for(int r = 0; r < lsitaClase.clase.Length; r++)
                {
                    if(lsitaClase.clase[r].Clave1 == CodigoClase)
                    {
                        Console.WriteLine("**********************************");
                        Console.Write("Codigo del alumno ");
                        string k = Console.ReadLine();
                        for (int i = 0; i < LsitaAlumno.Alumno1.Length; i++)
                        {
                            if (LsitaAlumno.Alumno1[i].Codigo1 == k)
                            {
                                Console.Write("Calificacion ");
                                int cal = Convert.ToInt32(Console.ReadLine());                                
                                
                                calificaciones[i] = calificaciones[i] + cal;

                                Console.WriteLine(LsitaAlumno.Alumno1[i].AlumnoDatos + " { Calificacion= " + cal + "}");
                            }
                        }
                        Console.WriteLine("**********************************");
                    }
                }
            }                
        }
        
            static void Main(string[] args)
        {
            Menu();
        }
    }
}
