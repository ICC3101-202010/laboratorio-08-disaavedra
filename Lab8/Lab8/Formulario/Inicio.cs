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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Revisar_Click(object sender, EventArgs e)
        {
            using (Revisar ventanaRevisar = new Revisar())
                ventanaRevisar.ShowDialog();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            using (Agregar ventanaAgregar = new Agregar())
                ventanaAgregar.ShowDialog();
        }

        private void ATvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
