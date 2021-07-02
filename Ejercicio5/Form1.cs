using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[Convert.ToInt32(txt_tamaño.Text), Convert.ToInt32(txt_numero.Text)];
            Random matrizaleatoria = new Random();

            for (int fila = 0; fila < matriz.GetLength(0); fila++)

            {
                for(int columna=0; columna < matriz.GetLength(1); columna++)
                {
                    matriz[fila,columna ] = matrizaleatoria.Next(0, 100);
                    MessageBox.Show("La posicion es:" + fila + "," + columna + "=" + matriz[fila, columna].ToString());

                }

            }
        }
    }
}
