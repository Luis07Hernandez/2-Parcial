using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadGraficoPorTortuga
{
    public partial class Form1 : Form
    {
        Tortuga torta = new Tortuga();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtBxTablero.Text = torta.ToString();
        }

        private void btnSubirPluma_Click(object sender, EventArgs e)
        {
            torta.subirPluma();
        }

        private void btnBajarPluma_Click(object sender, EventArgs e)
        {
            torta.bajarPluma();
        }

        private void btnGirarADerecha_Click(object sender, EventArgs e)
        {
            torta.girarADerecha();
        }

        private void btnGirarAIzquierda_Click(object sender, EventArgs e)
        {
            torta.girarAIzquierda();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            torta.avanzar(int.Parse(txtBxPosiciones.Text));
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            torta.fin();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
