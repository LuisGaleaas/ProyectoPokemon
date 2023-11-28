using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPokemon
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void btnIrAForm1_Click(object sender, EventArgs e)
        {
            // Abrir el Form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Opcional: Ocultar el formulario de inicio si lo prefieres

        }
    }
}
