using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.AnalizadorExpresionesAritmeticas
{
    public partial class Form1 : Form
    {
        Analizador analizador = new Analizador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string[] vec = txtBxExpresion.Text.Split(' ');
            foreach (string s in vec)
            {
                Nodo x = new Nodo(s);
                analizador.agregarFinal(x);
            }
            txtBxTabla.Text = analizador.analizar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBxExpresion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
