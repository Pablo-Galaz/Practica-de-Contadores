using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_Contadores
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Variables Globales
        

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumAnterior_Click(object sender, EventArgs e)
        {
            string obtenernumero = Numeros.Text;
            int convertir; 
            
            if(Convert.ToInt32(obtenernumero) == 0)
            {
                MessageBox.Show("No se puede obtener numeros menores que cero");
            }
            else
            {
                convertir = Convert.ToInt32(obtenernumero) - 1;
               
                Numeros.Text =  Convert.ToString(convertir);
            }
        }

        private void NumSiguiente_Click(object sender, EventArgs e)
        {
            string obtenernumero2 = Numeros.Text;
            int convertir1;

            if(Convert.ToInt32(obtenernumero2) == 25)
            {
                MessageBox.Show("No se pueden obtener numeros mayores a 25");
            }
            else
            {
                convertir1 = Convert.ToInt32(obtenernumero2) + 1;

                Numeros.Text = Convert.ToString(convertir1);
            }

        }

    }
}