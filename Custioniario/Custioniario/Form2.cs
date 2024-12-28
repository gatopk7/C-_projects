using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custioniario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();             
            Prguntas();            
        }

        public static int contador = 0, contadorPregunta = 0;
        public static int calPregunta1;

        private void Prguntas()
        {
            switch (contadorPregunta) 
            {
                case 0:
                    lblPreguntas.Text = "¿Que es un Windows Forms?";
                    radioButton1.Text = "Un formulario";
                    radioButton2.Text = "Aplicación de interfaz garfica";
                    radioButton3.Text = "Una clase";
                    break;
                case 1:
                    lblPreguntas.Text = "¿2 Controles de windows Forms?";
                    radioButton1.Text = "JButton Y Panel";
                    radioButton2.Text = "JPanel Y JMenu";
                    radioButton3.Text = "Button y Label";
                    break;
                case 2:
                    lblPreguntas.Text = "¿2 Controles que no son de Windows Forms?";
                    radioButton1.Text = "Jbuton y JPanel";
                    radioButton2.Text = "Label Y Menu";
                    radioButton3.Text = "MenuBar y Button";
                    break;
                case 3:
                    lblPreguntas.Text = "¿Que componentes vienen al crear un windows Forms?";
                    radioButton1.Text = "Un boton";
                    radioButton2.Text = "Un cubo";
                    radioButton3.Text = "Un Forms en blanco";
                    break;
                case 4:
                    lblPreguntas.Text = "¿Que es una interfaz?";
                    radioButton1.Text = "No se";
                    radioButton2.Text = "Contenedor de elementos visuales";
                    radioButton3.Text = "Esa palabra no existe";
                    break;
                case 5:
                    lblPreguntas.Text = "¿Que se usaba antes de la intefaz?";
                    radioButton1.Text = "Un sistema llamado consola";
                    radioButton2.Text = "No se usaba nda";
                    radioButton3.Text = "Lapiz";
                    break;
                case 6:
                    lblPreguntas.Text = "¿Para que sirve un label?";
                    radioButton1.Text = "¿Que es un label?";
                    radioButton2.Text = "Para nada";
                    radioButton3.Text = "mostrar texto";
                    break;
                case 7:
                    lblPreguntas.Text = "¿Para que sive un Picture?";
                    radioButton1.Text = "Mostrar informacion";
                    radioButton2.Text = "Mostrar imgenes";
                    radioButton3.Text = "No se";
                    break;
                case 8:
                    lblPreguntas.Text = "¿Que nombre recibe un Forms al crearlo?";
                    radioButton1.Text = "Form1";
                    radioButton2.Text = "Forms1";
                    radioButton3.Text = "Form";
                    break;
                case 9:
                    lblPreguntas.Text = "¿Que color de fondo tiene por defecto un Form?";
                    radioButton1.Text = "No tiene colo";
                    radioButton2.Text = "Rojo";
                    radioButton3.Text = "Blanco";
                    break;
                default:
                    int calFinal = calPregunta1 / 10;
                    lblPreguntas.Text = "Felicidades tu calificacion es \n" + calFinal;
                    groupBox1.Visible = false;
                    btnComprobar.Visible = false;
                    lblInfo.Text = "FELICIDADES!! " + Form1.Nombre.ToUpper();
                    break;                    
            }
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            switch (contadorPregunta)
            {
                case 0:
                    if (contador < 3)
                    {
                        if (radioButton2.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contador = 0;
                        contadorPregunta++;
                        Prguntas();
                    }
                    break;
                case 1:
                    if (contador < 3)
                    {
                        if (radioButton3.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 2:
                    if (contador < 3)
                    {
                        if (radioButton1.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;

                case 3:
                    if (contador < 3)
                    {
                        if (radioButton3.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 4:
                    if (contador < 3)
                    {
                        if (radioButton2.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 5:
                    if (contador < 3)
                    {
                        if (radioButton1.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 6:
                    if (contador < 3)
                    {
                        if (radioButton3.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 7:
                    if (contador < 3)
                    {
                        if (radioButton2.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 8:
                    if (contador < 3)
                    {
                        if (radioButton1.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
                case 9:
                    if (contador < 3)
                    {
                        if (radioButton3.Checked)
                        {
                            switch (contador)
                            {
                                case 0:
                                    lblInfo.Text = "Correcto \n 100 puntos";
                                    calPregunta1 = calPregunta1 + 100;
                                    break;
                                case 1:
                                    lblInfo.Text = "Correcto \n 50 puntos";
                                    calPregunta1 = calPregunta1 + 50;
                                    break;
                                case 2:
                                    lblInfo.Text = "Correcto \n 25 puntos";
                                    calPregunta1 = calPregunta1 + 25;
                                    break;
                            }
                            contador = 0;
                            contadorPregunta++;
                            Prguntas();
                        }
                        else
                        {
                            lblInfo.Text = "Incorrecto";
                            contador++;
                        }
                    }
                    else
                    {
                        calPregunta1 = calPregunta1 + 25;
                        lblInfo.Text = "Se acabo la opartunidd \n 25 Puntos";
                        contadorPregunta++;
                        contador = 0;
                        Prguntas();
                    }
                    break;
            }
        }
    }
}
