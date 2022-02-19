using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_MC0826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agregarbnt_Click(object sender, EventArgs e)
        {
            string nombre=NombreTxt.Text;
            int edad= Convert.ToInt32(EdadTxt.Text);

            //Arreglo de Nombre del estudiante
            string[] arrEst = {nombre};


            //Arreglo de edad del Estudiante
           int[] arrEdad = new int[] {edad};


            comboBox1.Items.Add(nombre +" || " +edad+" Años");
        }

        private void cleanbnt_Click(object sender, EventArgs e)
        {
            EdadTxt.Clear();
            NombreTxt.Clear();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 )
            {           
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
    }
}
