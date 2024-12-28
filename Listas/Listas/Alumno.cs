using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Alumno
    {
        private string codigo;
        private string nombres;
        private string apellidos;
        private string carrera;
        private string grado;
        //constructores
        public Alumno()
        {
        }
        public Alumno(string codigo)
        {
            this.Codigo = codigo;
        }
        public Alumno(string codigo, string nombres, string apellidos, string carrera, string grado)
        {
            this.Codigo = codigo;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Carrera = carrera;
            this.Grado = grado;
        }
        //get y set
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        //equials y hashcode

        public override bool Equals(object obj)
        {
            return obj is Alumno alumno &&
                   codigo == alumno.codigo;
        }

        public override int GetHashCode()
        {
            return -1967093634 + EqualityComparer<string>.Default.GetHashCode(codigo);
        }
    }
}
