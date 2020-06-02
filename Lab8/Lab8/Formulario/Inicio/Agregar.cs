using Lab8.Formulario.Inicio.AgregarLocales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Aeleccion1_Click(object sender, EventArgs e)
        {
            using (AgregarTienda ventanaAgregarTienda = new AgregarTienda())
                ventanaAgregarTienda.ShowDialog();
        }

        private void Aeleccion2_Click(object sender, EventArgs e)
        {
            using (AgregarRestaurant ventanaAgregarRestaurante = new AgregarRestaurant())
                ventanaAgregarRestaurante.ShowDialog();
        }

        private void Aeleccion4_Click(object sender, EventArgs e)
        {
            using (AgregarRecreacional ventanaAgregarRecreacional = new AgregarRecreacional())
                ventanaAgregarRecreacional.ShowDialog();
        }

        private void Aeleccion3_Click(object sender, EventArgs e)
        {
            using (AgregarCine ventanaAgregarCine = new AgregarCine())
                ventanaAgregarCine.ShowDialog();
        }

        private void Avolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
