using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.ListasCircularesProcesos
{
    public partial class Form1 : Form
    {
        Procesador procesador = new Procesador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = procesador.procesar();
        }
    }
}
