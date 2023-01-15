using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Calculadora en source/repos/
namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool existe_punto = false;
        private char[] simbolos = { '+', '-', '÷', 'x' };   
        private void Form1_Load(object sender, EventArgs e)
        {
            tBoxPantalla.Text = "0";
            tableLayoutPanel1.Select();
            // double a = Convert.ToDouble("5+7");
            //MessageBox.Show();
        }
        private bool termina_en_numero()
        {
            //no esta en la version del video
            return char.IsDigit(tBoxPantalla.Text[tBoxPantalla.Text.Length - 1]);
        }
        private string[] dividir_cadena(string texto)
        {
            return texto.Split(simbolos);
        }
        private bool pantalla_es_cero()
        {
            return tBoxPantalla.Text.Equals("0");
        }
        private bool cadena_demasiado_larga()
        {
            //no esta en la version del video
            if (tBoxPantalla.Text.Length >= 40)
                return true;
            else return false;
        }
        private void agrega_elemento(string cad)
        {

            if (cadena_demasiado_larga()) return;
            if (pantalla_es_cero())
            {
                //if (Regex.IsMatch(cad, @"^\d+$"))
                //    tBoxPantalla.Text = cad;
                if (char.IsDigit(char.Parse(cad)))
                { 
                    tBoxPantalla.Text = cad; 
                }

                if (cad != ".")
                {
                    return;
                }

            }
            if (simbolos.Contains(char.Parse(cad)))
            {
                if (!termina_en_numero())
                {
                    tBoxPantalla.Text = tBoxPantalla.Text.Remove(tBoxPantalla.Text.Length - 1);
                }
            }

            if (tBoxPantalla.Text.EndsWith("%"))
            {
                if (char.IsDigit(char.Parse(cad)))
                {
                    tBoxPantalla.Text += "x";
                }
            }
            tBoxPantalla.Text += cad;
            //tBoxPantalla.Select(tBoxPantalla.Text.Length,0);
            tBoxPantalla.SelectionStart = tBoxPantalla.Text.Length;//para llevar el cursor al final del textbox
        }

        private void agregarNumero(string cad)
        {
            if (pantalla_es_cero())
            {
                tBoxPantalla.Text = cad;
                return;
            }
            if (tBoxPantalla.Text.EndsWith("%")) tBoxPantalla.Text += "x";
            if (dividir_cadena(tBoxPantalla.Text).Last().EndsWith("0") &&
                dividir_cadena(tBoxPantalla.Text).Last().Length <= 1)
            {
                tBoxPantalla.Text = tBoxPantalla.Text.Remove(tBoxPantalla.Text.Length - 1);
            }
            tBoxPantalla.Text += cad;
            tBoxPantalla.SelectionStart = tBoxPantalla.Text.Length;
        }
        private void agregarOperacion(string cad)
        {
            if (pantalla_es_cero() && !cad.Equals(".")) tBoxPantalla.Text = "";
            string texto = tBoxPantalla.Text[tBoxPantalla.Text.Length - 1].ToString();
            if (texto.Equals("x") || texto.Equals("÷") || texto.Equals("+") || texto.Equals("-"))
            {
                tBoxPantalla.Text = tBoxPantalla.Text.Remove(tBoxPantalla.Text.Length - 1);

            }
            tBoxPantalla.Text += cad;
            tBoxPantalla.SelectionStart = tBoxPantalla.Text.Length;
        }


        //continuacion--->


        #region numeros_click
        private void btnCero_Click(object sender, EventArgs e)
        {
            if (tBoxPantalla.Text.EndsWith("0"))
            {
                if (dividir_cadena(tBoxPantalla.Text)[dividir_cadena(tBoxPantalla.Text).Length - 1].Length <= 1)
                    return;
            }
            agrega_elemento("0");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            agrega_elemento("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            agrega_elemento("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            agrega_elemento("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            agrega_elemento("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            agrega_elemento("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            agrega_elemento("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            agrega_elemento("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            agrega_elemento("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            agrega_elemento("9");
        }



        #endregion


        private void btnCambiaSigno_Click(object sender, EventArgs e)
        {
            if (pantalla_es_cero()) return;
            if (!double.TryParse(tBoxPantalla.Text, out _)) return;
            double temporal = Convert.ToDouble(tBoxPantalla.Text);
            temporal *= -1;
            tBoxPantalla.Text = temporal.ToString();
        }


        private void btnPunto_Click(object sender, EventArgs e)
        {
            //if (pantalla_es_cero()) return;
            if (existe_punto) return;
            if (!termina_en_numero()) return;
            agrega_elemento(".");
            existe_punto = true;
        }


        //-----------------
        private void btnInversa_Click(object sender, EventArgs e)
        {
            if (pantalla_es_cero()) return;
            if (!double.TryParse(tBoxPantalla.Text, out _)) return;
            double temporal = Convert.ToDouble(tBoxPantalla.Text);
            temporal = 1 / temporal;
            tBoxPantalla.Text = temporal.ToString();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            if (pantalla_es_cero()) return;
            if (!double.TryParse(tBoxPantalla.Text, out _)) return;
            double temporal = Convert.ToDouble(tBoxPantalla.Text);
            temporal *= temporal;
            tBoxPantalla.Text = temporal.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (pantalla_es_cero()) return;
            if (!double.TryParse(tBoxPantalla.Text, out _)) return;
            double temporal = Convert.ToDouble(tBoxPantalla.Text);
            temporal = Math.Sqrt(temporal);
            tBoxPantalla.Text = temporal.ToString();
        }






        private void btnDividir_Click(object sender, EventArgs e)
        {
            agrega_elemento("÷");
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            agrega_elemento("x");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            agrega_elemento("-");
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            agrega_elemento("+");
        }




        private void tBoxPantalla_TextChanged(object sender, EventArgs e)
        {
            string ultimoNumeroString = dividir_cadena(tBoxPantalla.Text)[dividir_cadena(tBoxPantalla.Text).Length - 1];
            if (ultimoNumeroString.Contains('.'))
            {
                existe_punto = true;
            }
            else { existe_punto = false; }
        }


        private void btnC_Click(object sender, EventArgs e)
        {
            if (pantalla_es_cero()) return;
            tBoxPantalla.Text = "0";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            foreach (var simbolo in simbolos)
            {
                if (tBoxPantalla.Text.EndsWith(simbolo.ToString())) return;
            }
            if (tBoxPantalla.Text.EndsWith("."))
                tBoxPantalla.Text = tBoxPantalla.Text.Remove(tBoxPantalla.Text.Length - 1);
            agrega_elemento("%");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //TODO
            if (pantalla_es_cero()) return;
            if (!termina_en_numero() && !tBoxPantalla.Text.EndsWith("%")) return;
            var numeroString = dividir_cadena(tBoxPantalla.Text)[dividir_cadena(tBoxPantalla.Text).Length - 1];
            tBoxPantalla.Text = tBoxPantalla.Text.Remove(tBoxPantalla.Text.Length - numeroString.Length);
            if (tBoxPantalla.Text.Equals("")) tBoxPantalla.Text = "0";
            tBoxPantalla.SelectionStart = tBoxPantalla.Text.Length;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (pantalla_es_cero()) return;
            tBoxPantalla.Text = tBoxPantalla.Text.Remove(tBoxPantalla.Text.Length - 1);
            if (tBoxPantalla.Text.Length == 0) tBoxPantalla.Text = "0";
            tBoxPantalla.SelectionStart = tBoxPantalla.Text.Length;
        }

        private bool tieneValor(double value)
        {
            return !Double.IsNaN(value) && !Double.IsInfinity(value);
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            //aqui va la magia ;)
            if (pantalla_es_cero()) return;
            if (!termina_en_numero() && !tBoxPantalla.Text.EndsWith("%")) return;

            string textoOperacional = tBoxPantalla.Text;
            if (textoOperacional.Contains("%"))
            {
                textoOperacional = textoOperacional.Replace("%", "÷100");
            }
            if (textoOperacional.Contains("x") || textoOperacional.Contains("÷"))
            {
                char[] ope_super = { '÷', 'x' };
                int indiceOpeSuper, indiceOpeAnterior, indiceOpeSiguiente;
                string parte1, parte2, subResultado;
                // if(indiceOpeAnterior<0) si es 0 se le sumara 1 igual D:

                while (textoOperacional.Contains("x") || textoOperacional.Contains("÷"))
                {
                    indiceOpeSuper = textoOperacional.IndexOfAny(ope_super);
                    indiceOpeAnterior = textoOperacional.LastIndexOfAny(simbolos, indiceOpeSuper - 1, indiceOpeSuper);
                    indiceOpeSiguiente = textoOperacional.IndexOfAny(simbolos, indiceOpeSuper + 1);
                    //MessageBox.Show(""+indiceOpeSuper+" "+indiceOpeAnterior+" "+indiceOpeSiguiente);
                    parte1 = textoOperacional.Substring(indiceOpeAnterior + 1, indiceOpeSuper - indiceOpeAnterior - 1);
                   
                    if (indiceOpeSiguiente < 0)
                    {
                        parte2 = textoOperacional.Substring(indiceOpeSuper + 1);
                    }
                    else
                    {
                        parte2 = textoOperacional.Substring(indiceOpeSuper + 1, indiceOpeSiguiente - indiceOpeSuper - 1);
                    }
                    if (textoOperacional[indiceOpeSuper].Equals('x'))
                    {

                        //subResultado = (Convert.ToDouble(parte1) * Convert.ToDouble(parte2)).ToString();
                        subResultado = (Convert.ToDouble(parte1) * Convert.ToDouble(parte2)).ToString("0." + new string('#', 339));
                        //Para evitar la notacion cientifica
                    }
                    else
                    {
                        // subResultado = (Convert.ToDouble(parte1) / Convert.ToDouble(parte2)).ToString();
                        double numResultado = Convert.ToDouble(parte1) / Convert.ToDouble(parte2);
                        if (!tieneValor(numResultado))
                        {
                            MessageBox.Show("El resultado no es un numero finito");
                            tBoxPantalla.Text = "0";
                            return;
                        }
                        subResultado = (numResultado).ToString("0." + new string('#', 339));
                    }
                    if (indiceOpeSiguiente < 0)
                    {
                        textoOperacional = textoOperacional.Remove(indiceOpeAnterior + 1).Insert(indiceOpeAnterior + 1, subResultado);
                    }
                    else
                    {
                        //MessageBox.Show(textoOperacional);
                        textoOperacional = textoOperacional.Remove(indiceOpeAnterior + 1, indiceOpeSiguiente - indiceOpeAnterior - 1).Insert(indiceOpeAnterior + 1, subResultado);
                       // MessageBox.Show(textoOperacional);
                    }



                    //MessageBox.Show(indiceOpeSuper.ToString());
                    //MessageBox.Show(indiceOpeAnterior.ToString());
                    //MessageBox.Show(indiceOpeSiguiente.ToString());

                }
                // MessageBox.Show(textoOperacional);
            }
            if (textoOperacional.Contains("+") || textoOperacional.Contains("-"))
            {
                char[] ope_super = { '+', '-' };
                int indiceOpeSuper, indiceOpeAnterior, indiceOpeSiguiente;
                string parte1, parte2, subResultado;
                // if(indiceOpeAnterior<0) si es 0 se le sumara 1 igual D:
                
                while (textoOperacional.Contains("+") || textoOperacional.Contains("-"))
                {
                    //if(textoOperacional.Split(ope_super).Length)
                    if (textoOperacional.Split(ope_super, StringSplitOptions.RemoveEmptyEntries).Length <= 1)
                        break;
                    if (textoOperacional.StartsWith("-"))
                    {
                        string primerNumero = textoOperacional.Split(ope_super)[1];
                        textoOperacional = textoOperacional.Substring(1) + "-" + (2 * Convert.ToDouble(primerNumero)).ToString("0." + new string('#', 339));
                    }
                    indiceOpeSuper = textoOperacional.IndexOfAny(ope_super);
                    indiceOpeAnterior = textoOperacional.LastIndexOfAny(simbolos, indiceOpeSuper - 1, indiceOpeSuper);
                    indiceOpeSiguiente = textoOperacional.IndexOfAny(simbolos, indiceOpeSuper + 1);

                    // parte1 = textoOperacional.Substring(indiceOpeAnterior + 1, indiceOpeSuper - indiceOpeAnterior - 1);
                    parte1 = textoOperacional.Substring(0, indiceOpeSuper);
                    if (indiceOpeSiguiente < 0)
                    {
                        parte2 = textoOperacional.Substring(indiceOpeSuper + 1);
                    }
                    else
                    {
                        parte2 = textoOperacional.Substring(indiceOpeSuper + 1, indiceOpeSiguiente - indiceOpeSuper - 1);
                    }
                    if (textoOperacional[indiceOpeSuper].Equals('+'))
                    {

                        //subResultado = (Convert.ToDouble(parte1) + Convert.ToDouble(parte2)).ToString();
                        subResultado = (Convert.ToDouble(parte1) + Convert.ToDouble(parte2)).ToString("0." + new string('#', 339));
                    }
                    else
                    {
                        // subResultado = (Convert.ToDouble(parte1) - Convert.ToDouble(parte2)).ToString();
                        subResultado = (Convert.ToDouble(parte1) - Convert.ToDouble(parte2)).ToString("0." + new string('#', 339));
                    }
                    if (indiceOpeSiguiente < 0)
                    {
                        // textoOperacional = textoOperacional.Remove(indiceOpeAnterior + 1).Insert(indiceOpeAnterior + 1, subResultado);
                        textoOperacional = subResultado;
                    }
                    else
                    {
                        // textoOperacional = textoOperacional.Remove(indiceOpeAnterior + 1, indiceOpeSiguiente - indiceOpeAnterior - 1).Insert(indiceOpeAnterior + 1, subResultado);
                        textoOperacional = textoOperacional.Remove(0, indiceOpeSiguiente).Insert(0, subResultado);
                    }

                    //MessageBox.Show(indiceOpeSuper.ToString());
                    //MessageBox.Show(indiceOpeAnterior.ToString());
                    //MessageBox.Show(indiceOpeSiguiente.ToString());

                }
                //MessageBox.Show(textoOperacional);
            }

            tBoxPantalla.Text = textoOperacional;
        }
    }
}
