using LibDatos.Dac;
using LibDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {

            MostrarTodosLosAviones();
        }
        private void btnInsertarAvion_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea() { Nombre = "Aerolineas"};

            Avion avion = new Avion() {Capacidad = 200, Denominacion = "Comercial", LineaAerea = lineaAerea};


            if (AbmAviones.Insert(avion) > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarTodosLosAviones();
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea() { Nombre = "Aerolineas" };
            Avion avion = new Avion() { AvionId = Convert.ToInt32(txtId.Text), Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text, LineaAerea = lineaAerea };


            if (AbmAviones.Update(avion) > 0)
            {
                MessageBox.Show("Update ok");
                MostrarTodosLosAviones();
            }
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Avion avion = AbmAviones.SelectWhereById(id);
            MessageBox.Show(avion.Denominacion);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            Avion avion = new Avion() { AvionId = Convert.ToInt32(txtId.Text)};


            if (AbmAviones.Delete(avion) > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarTodosLosAviones();
            }

        }
        private void MostrarTodosLosAviones()
        {
            gridAviones.DataSource = AbmAviones.SelectAll();
        }
    }
}
