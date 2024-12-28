using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanaCurp
{
    internal class Persona
    {
        String apellido1, apellido2, nom1, nom2,
            estado, sexo, dia, mes, anho, curp;

        public Persona(string curp)
        {
            this.curp = curp ?? throw new ArgumentNullException(nameof(curp));
        }

        public Persona(string apellido1, string apellido2, string nom1, string nom2, string estado, string sexo, string anho, string mes, string dia, string curp) : this(apellido1)
        {
            this.apellido2 = apellido2 ?? throw new ArgumentNullException(nameof(apellido2));
            this.nom1 = nom1 ?? throw new ArgumentNullException(nameof(nom1));
            this.nom2 = nom2 ?? throw new ArgumentNullException(nameof(nom2));
            this.estado = estado ?? throw new ArgumentNullException(nameof(estado));
            this.sexo = sexo ?? throw new ArgumentNullException(nameof(sexo));
            this.curp = curp ?? throw new ArgumentNullException(nameof(curp));
        }

        public Persona()
        {
        }

        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Nom1 { get => nom1; set => nom1 = value; }
        public string Nom2 { get => nom2; set => nom2 = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Anho { get => Anho1; set => Anho1 = value; }
        public string Curp { get => curp; set => curp = value; }
        public string Dia { get => Dia2; set => Dia2 = value; }
        public string Mes { get => Mes2; set => Mes2 = value; }
        public string Dia1 { get => Dia2; set => Dia2 = value; }
        public string Mes1 { get => Mes2; set => Mes2 = value; }
        public string Dia2 { get => dia; set => dia = value; }
        public string Mes2 { get => mes; set => mes = value; }
        public string Anho1 { get => anho; set => anho = value; }

        public override bool Equals(object obj)
        {
            return obj is Persona persona &&
                   curp == persona.curp &&
                   Curp == persona.Curp;
        }

        public override int GetHashCode()
        {
            int hashCode = 324387894;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(curp);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Curp);
            return hashCode;
        }
        public string generarCURP(String appellido1, String apelllido2, String nom1, String estado, String sexo, int anho, int mes, int dia )
        {
            string[] Curp = new string[18];
            if (Curp[0] == null)
            {
                Curp[0] = apellido1.Substring(0, 1).ToUpper();
            }

            if (Curp[1] == null)
            {
                for (int i = 1; i < apellido1.Length; i++)
                {
                    string compara;
                    compara = Convert.ToString(apellido1[i]);

                    if (compara.ToUpper().Equals("A"))
                    {
                        Curp[1] = "A";
                        break;
                    }
                    else if (compara.ToUpper().Equals("E"))
                    {
                        Curp[1] = "E";
                        break;
                    }
                    if (compara.ToUpper().Equals("I"))
                    {
                        Curp[1] = "I";
                        break;
                    }
                    if (compara.ToUpper().Equals("O"))
                    {
                        Curp[1] = "O";
                        break;
                    }
                    if (compara.ToUpper().Equals("U"))
                    {
                        Curp[1] = "U";
                        break;
                    }
                }
            }

            if (Curp[2] == null)
            {
                Curp[2] = apellido2.Substring(0, 1).ToUpper();
            }

            if (Curp[3] == null)
            {
                Curp[3] = nom1.Substring(0, 1).ToUpper();
            }

            if (Curp[4] == null)
            {
                Curp[4] = anho.ToString().Substring(2, 1);
            }
            if (Curp[5] == null)
            {
                Curp[5] = anho.ToString().Substring(3, 1);
            }

            if (Curp[6] == null && Curp[7] == null)
            {
                if (mes < 10)
                {
                    Curp[6] = 0.ToString();
                    Curp[7] = mes.ToString();
                }
                else if (mes.ToString().Length == 2)
                {
                    Curp[6] = mes.ToString().Substring(0, 1);
                    Curp[7] = mes.ToString().Substring(1, 1);
                }
            }

            if (Curp[8] == null & Curp[9] == null)
            {
                if (dia < 10)
                {
                    Curp[8] = 0.ToString();
                    Curp[9] = dia.ToString();
                }
                else if (dia.ToString().Length == 2)
                {
                    Curp[8] = dia.ToString().Substring(0, 1);
                    Curp[9] = dia.ToString().Substring(1, 1);
                }
            }

            if (Curp[10] == null)
            {
                if (sexo.ToUpper().Equals("Hombre") || sexo.ToUpper().Equals("M"))
                {
                    Curp[10] = sexo.ToUpper();
                }
            }
            if (Curp[11] == null & Curp[12] == null)
            {

                switch (estado.ToUpper())
                {
                    case "JALISCO":
                        Curp[11] = "J";
                        Curp[12] = "C";
                        break;

                    case "AGUASCALIENTES":
                        Curp[11] = "A";
                        Curp[12] = "S";
                        break;

                    case "BAJA CALIFORNIA SUR":
                        Curp[11] = "B";
                        Curp[12] = "S";
                        break;

                    case "COAHUILA":
                        Curp[11] = "C";
                        Curp[12] = "L";
                        break;

                    case "DISTRITO FEDERAL":
                        Curp[11] = "D";
                        Curp[12] = "F";
                        break;

                    case "GUANAJUATO":
                        Curp[11] = "G";
                        Curp[12] = "T";
                        break;

                    case "HIDALGO":
                        Curp[11] = "H";
                        Curp[12] = "G";
                        break;

                    case "MEXICO":
                        Curp[11] = "M";
                        Curp[12] = "C";
                        break;

                    case "MORELOS":
                        Curp[11] = "M";
                        Curp[12] = "S";
                        break;

                    case "NUEVO LEON":
                        Curp[11] = "N";
                        Curp[12] = "L";
                        break;

                    case "PUEBLA":
                        Curp[11] = "P";
                        Curp[12] = "L";
                        break;

                    case "QUINTANA ROO":
                        Curp[11] = "Q";
                        Curp[12] = "R";
                        break;

                    case "TABASCO":
                        Curp[11] = "T";
                        Curp[12] = "C";
                        break;

                    case "TLAXCALA":
                        Curp[11] = "T";
                        Curp[12] = "L";
                        break;

                    case "SINALOA":
                        Curp[11] = "S";
                        Curp[12] = "L";
                        break;

                    case "BAJA CALIFORNIA":
                        Curp[11] = "B";
                        Curp[12] = "C";
                        break;

                    case "CAMPECHE":
                        Curp[11] = "C";
                        Curp[12] = "C";
                        break;

                    case "COLIMA":
                        Curp[11] = "C";
                        Curp[12] = "M";
                        break;

                    case "CHIHUAHUA":
                        Curp[11] = "C";
                        Curp[12] = "H";
                        break;

                    case "DURANGO":
                        Curp[11] = "D";
                        Curp[12] = "G";
                        break;

                    case "GUERRERO":
                        Curp[11] = "G";
                        Curp[12] = "R";
                        break; ;

                    case "MICHOACAN":
                        Curp[11] = "M";
                        Curp[12] = "N";
                        break;

                    case "NAYARIT":
                        Curp[11] = "N";
                        Curp[12] = "T";
                        break;

                    case "OAXACA":
                        Curp[11] = "O";
                        Curp[12] = "C";
                        break;

                    case "QUERETARO":
                        Curp[11] = "Q";
                        Curp[12] = "T";
                        break;

                    case "SAN LUIS POTOSI":
                        Curp[11] = "S";
                        Curp[12] = "P";
                        break;

                    case "SONORA":
                        Curp[11] = "S";
                        Curp[12] = "R";
                        break;

                    case "TAMALUIPAS":
                        Curp[11] = "T";
                        Curp[12] = "S";
                        break;

                    case "VERACRUZ":
                        Curp[11] = "V";
                        Curp[12] = "Z";
                        break;

                    case "ZACATECAS":
                        Curp[11] = "Z";
                        Curp[12] = "S";
                        break;

                    case "YUCATAN":
                        Curp[11] = "Y";
                        Curp[12] = "N";
                        break;

                    case "NE":
                        Curp[11] = "N";
                        Curp[12] = "E";
                        break;
                    default:
                        Console.WriteLine(" El estado que ingresaste es incorrecto ");
                        break;
                }
            }

            if (Curp[13] == null && Curp[14] == null && Curp[15] == null)
            {
                string[] consonantes = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z", };
                consonantes.ToString();

                for (int i = 1; i < apellido1.Length; i++)
                {
                    for (int k = 0; k < consonantes.Length; k++)
                    {
                        string compara = Convert.ToString(apellido1[i]).ToUpper();

                        if (consonantes[k].Equals(compara))
                        {
                            Curp[13] = compara;
                            break;
                        }
                    }
                    if (Curp[13] != null)
                    {
                        break;
                    }
                }
                for (int i = 1; i < apellido2.Length; i++)
                {
                    for (int k = 0; k < consonantes.Length; k++)
                    {
                        string compara = Convert.ToString(apellido2[i]).ToUpper();

                        if (consonantes[k].Equals(compara))
                        {
                            Curp[14] = compara;
                            break;
                        }
                    }
                    if (Curp[14] != null)
                    {
                        break;
                    }
                }

                for (int i = 1; i < nom1.Length; i++)
                {
                    for (int k = 0; k < consonantes.Length; k++)
                    {
                        string compara = Convert.ToString(nom1[i]).ToUpper();

                        if (consonantes[k].Equals(compara))
                        {
                            Curp[15] = compara;
                            break;
                        }
                    }
                    if (Curp[15] != null)
                    {
                        break;
                    }
                }
            }
            if (Curp[16] == null)
            {
                if (anho < 2000)
                {
                    Curp[16] = "0";
                }
                else if (anho > 1999)
                {
                    Curp[16] = "A";
                }
            }

            if (Curp[17] == null)
            {
                Random ra = new Random();
                int numero_verificador = ra.Next(0, 9);
                Curp[17] = numero_verificador.ToString();
            }

            curp = string.Concat(Curp);

            return "Curp:" + curp;
        }

        public override string ToString()
        {

            string clave = string.Concat(Curp);
            return clave;

        }
    }

            
}
