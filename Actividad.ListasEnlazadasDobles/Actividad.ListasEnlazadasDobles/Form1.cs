using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad.ListasEnlazadasDobles
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();

        public Form1()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txtBxTelefono.Text = "";
            txtBxNombre.Text = "";
            txtBxEmail.Text = "";
            txtBxEdad.Text = "";
            txtBxAPaterno.Text = "";
            txtBxAMaterno.Text = "";
            txtBxTelBuscar.Text = "";
            txtBxNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contacto cX = new Contacto();

            cX.Nombre = txtBxNombre.Text;
            cX.APaterno = txtBxAPaterno.Text;
            cX.AMaterno = txtBxAMaterno.Text;
            cX.Telefono = txtBxTelefono.Text;
            cX.Edad = txtBxEdad.Text;
            cX.Email = txtBxEmail.Text;

            agenda.agregar(cX, txtBxTelefono.Text);
            MessageBox.Show("Contacto Agregado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clear();
        }

        private void txtBxBuscar_Click(object sender, EventArgs e)
        {
            Contacto contacto = agenda.buscar(txtBxTelBuscar.Text);

            if (contacto == null)
            {
                MessageBox.Show("Contacto No Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            else
            {
                txtBxNombre.Text = contacto.Nombre;
                txtBxAPaterno.Text = contacto.APaterno;
                txtBxAMaterno.Text = contacto.AMaterno;
                txtBxTelefono.Text = contacto.Telefono;
                txtBxEdad.Text = contacto.Edad;
                txtBxEmail.Text = contacto.Email;
                MessageBox.Show("Contacto Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            agenda.eliminar(txtBxTelefono.Text);
            MessageBox.Show("Contacto Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = agenda.listar();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            agenda.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            agenda.eliminarUltimo();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtBxTabla.Text = agenda.reporteInverso();
        }
    }
}
