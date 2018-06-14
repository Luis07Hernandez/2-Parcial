using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.ListasEnlazadas
{
    public partial class Form1 : Form
    {
        Catalogo cat = new Catalogo();

        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtMarca.Text = "";
            txtBxNombre.Text = "";
            txtcColor.Text = "";
            txtmModelo.Text = "";
            txtpPlaca.Text = "";
            txtBuscar.Text = "";
            txtBxNombre.Focus();        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Carro cX = new Carro();

            cX.Nombre = txtBxNombre.Text;
            cX.mModelo = txtmModelo.Text;
            cX.pPlaca = txtpPlaca.Text;
            cX.mMarca = txtMarca.Text;
            cX.cColor = txtcColor.Text;
            

            cat.agregar(cX);
            MessageBox.Show("Contacto Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            clear();
        }

        private void txtBxBuscar_Click(object sender, EventArgs e)
        {
            Carro carro = cat.buscar(txtBuscar.Text);

            if (cat.buscar(txtBuscar.Text) == null)
            {
                MessageBox.Show("Auto No Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                txtBxNombre.Text = carro.Nombre;
                txtmModelo.Text = carro.mModelo;
                txtpPlaca.Text = carro.pPlaca;
                txtMarca.Text = carro.mMarca;
                txtcColor.Text = carro.cColor;
                
                MessageBox.Show("Auto Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cat.eliminar(txtMarca.Text);
            MessageBox.Show("Auto Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = cat.listar();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            cat.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            cat.eliminarUltimo();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = cat.reporteInverso();
        }

        private void btnInvertirLista_Click(object sender, EventArgs e)
        {
            cat.invertirLista();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();

            car.Nombre = txtBxNombre.Text;
            car.mModelo = txtmModelo.Text;
            car.pPlaca = txtpPlaca.Text;
            car.mMarca = txtMarca.Text;
            car.cColor = txtcColor.Text;
            

            cat.insertar(int.Parse(txtPosicion.Text), car);
        }

        private void txtBxTelBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
