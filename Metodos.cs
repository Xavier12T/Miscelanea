using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace numeros
{
    class Metodos
    {
        public int numero { get; set; }
        public int posicion { get; set; }

        StreamWriter sw = new StreamWriter("Numeros.txt");
        
        List<int> listageneral = new List<int>();
        public void agregar(TextBox txtnumero)
        {   
            numero = int.Parse(txtnumero.Text);
            listageneral.Add(numero);
            

        }
        public void eliminar(TextBox txtnumero)
        {

            numero = int.Parse(txtnumero.Text);
            listageneral.Remove(numero);
        }
        public void eliminarxposicion(TextBox txtposicion)
        {
            
             posicion = int.Parse(txtposicion.Text);
            listageneral.RemoveAt(posicion);

        }
        public void agregarxposicon(TextBox txtnumero, TextBox txtposicion)
        {
            try
            {
                numero = int.Parse(txtnumero.Text);
                posicion = int.Parse(txtposicion.Text);
                listageneral.Insert(posicion, numero);
            }
            catch (Exception)
            {
                MessageBox.Show("Posicion no encontrada");
            }
           

        }
        public void resultado(ListBox lstresultado)
        {
            lstresultado.Items.Clear();
            
            for (int i = 0; i < listageneral.Count; i++)
            {
                lstresultado.Items.Add(listageneral.ElementAt(i));
            }

            
        }
        public void guardar(TextBox numero)
        {
            
            sw.WriteLine("Numero: " + numero.Text);
            sw.Flush();
           
        }
        public Boolean esnumero(TextBox txtnumero)
        {
            try
            {
                numero = int.Parse(txtnumero.Text);
                

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
