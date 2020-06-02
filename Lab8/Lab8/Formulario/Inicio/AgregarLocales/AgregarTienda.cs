using Lab8.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8.Formulario.Inicio.AgregarLocales
{
    public partial class AgregarTienda : Form
    {
        Central central = new Central();

        string[] categorias = { "Musica", "Alimentos", "Ropa", "Tecnologia", "Deportes" };
        public AgregarTienda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //
        }

        private void ATvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void AgregarTienda_Load(object sender, EventArgs e)
        {
            Categorias();
        }

        void Categorias()
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                comboBox2.Items.Add(categorias[i]);
                comboBox1.Items.Add(categorias[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            central.CreacionTienda(textBox1.Text, textBox2.Text, textBox3.Text);
            central.CreacionTienda(textBox1.Text, textBox2.Text, textBox3.Text).AgregarCategoria(comboBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
