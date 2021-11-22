using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros
{
    public partial class Form1 : Form
    {
        Metodos obj = new Metodos();

      

        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!obj.esnumero(txtnumero))
            
            {
                MessageBox.Show("Formato Incorrecto,Ingrese un Numero");

            }           
            else
            {
                obj.agregar(txtnumero);
                obj.guardar(txtnumero);
            }
            
            
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
          

                obj.resultado(lstresultado);
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (!obj.esnumero(txtposicion))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese numeros");
            }
            else if (!obj.esnumero(txtnumero))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese numeros"); }

            else
            {
                obj.agregarxposicon(txtnumero, txtposicion);
            }
           
        }

        private void btnEliminarxposicion_Click(object sender, EventArgs e)
        {
            if (!obj.esnumero(txtposicion))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese numeros");
            }
            

            else
            {
                obj.eliminarxposicion(txtposicion);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.eliminar(txtnumero);
            }
            catch (Exception)
            {
                MessageBox.Show("Error No hay elementos que eliminar");
            }
           
               
            
        }

       

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            Recursividad p = new Recursividad();
           
           
            if (!obj.esnumero(txtpotencia))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese numeros");
            }
            else if (!obj.esnumero(txtnumero2))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese numeros");
            }

            else
            {
                int n = int.Parse(txtnumero2.Text);
                int potencia = int.Parse(txtpotencia.Text);
                txtresusltado.Text = p.potencia(n, potencia).ToString();
            }

        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {

            Recursividad f = new Recursividad();
             
            
            if (!obj.esnumero(txtnumero2))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese un Numero");

            }
            else
            {
                int n = int.Parse(txtnumero2.Text);
                txtresusltado.Text =f.factorial(n).ToString();
            }
        }







        int[] vector = new int[100];
        public void generardatos(int n)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = aleatorio.Next(1,101);
            }
        }
       public void burbuja(int n)
        {
            int recorrido, actual, aux;
            for (recorrido = 1; recorrido < n; recorrido++)
            {
                for (actual=0;actual<n-recorrido;actual++)
                {
                    if(vector[actual] > vector[actual + 1])
                    {
                        aux = vector[actual];
                        vector[actual] = vector[actual + 1];
                        vector[ actual+1]= aux;
                    }

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbgenerar.Items.Clear();
            lbordenar.Items.Clear();
            if (!obj.esnumero(txtcanti))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese un Numero");

            }
            else
            {
                int n;
                n = int.Parse(txtcanti.Text);
                generardatos(n);
                mostrar(n, lbgenerar);
                button1.Enabled = true;
            }
        }
        public void mostrar(int n,ListBox lbgenerar)
        {
            for (int i = 0; i < n; i++)
            {
                lbgenerar.Items.Add(vector[i]);
            }
        }

        private void txtordenar_Click(object sender, EventArgs e)
        {
            if (!obj.esnumero(txtcanti))

            {
                MessageBox.Show("Formato Incorrecto,Ingrese numeros");
            }


            else
            {
                int n;
                n = int.Parse(txtcanti.Text);
                burbuja(n);
                mostrar(n, lbordenar);
                txtordenar.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
