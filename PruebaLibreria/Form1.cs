using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLibreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibreriaJaita.Punto p1 = new LibreriaJaita.Punto();
            p1.X = 8;
            p1.Y = 0;
            if(p1.Iguales())
            {
                MessageBox.Show("Coordenadas iguales");
            }
            else
            {
                MessageBox.Show("Coordenadas diferentes");
            }
            if(p1.SobreEje())
            {

                MessageBox.Show("verdadero");
            }
            else
            {
                MessageBox.Show("falso");
            }

            MessageBox.Show("CX:" + p1.X + "CY:" + p1.Y);
        }

        private void btnPunto2_Click(object sender, EventArgs e)
        {
            LibreriaJaita.Punto p2 = new LibreriaJaita.Punto();
            p2.X = 8;
            p2.Y = 9;
            if (p2.SobreEje())
            {

                MessageBox.Show("verdadero");
            }
            else
            {
                MessageBox.Show("falso");
            }
            MessageBox.Show("CX:" + p2.X + "CY:" + p2.Y);
        }

        private void btnPunto3_Click(object sender, EventArgs e)
        {
            LibreriaJaita.Punto p1 = new LibreriaJaita.Punto();
            p1.X = 3;
            p1.Y = 3;
            LibreriaJaita.Punto p3 = new LibreriaJaita.Punto();
            p3.X = 3;
            p3.Y = 3;

            if (p1.Iguales(p3)) 
            {
                MessageBox.Show("Iguales");
            }
            else
            {
                MessageBox.Show("distintos");
            }
            MessageBox.Show(("CX:" + p3.X + "CY:" + p3.Y)+("CX:" + p1.X + "CY:" + p1.Y));
            
        }
    }
}
