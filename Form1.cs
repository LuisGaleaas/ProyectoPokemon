using ProyectoPokemon.mods;
using System.Windows.Forms;

namespace ProyectoPokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rellenarTabla();
            rellenarMazoUno();
            rellenarMazoDos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void rellenarTabla()
        {
            Cartas pokemon = new Cartas();

            List<Cartas> listPokemon = pokemon.getPokemo();
            dtPokemon.Rows.Clear();
            foreach (var itemPokemon in listPokemon)
            {
                Cartas carta = (Cartas)itemPokemon;
                dtPokemon.Rows.Add(new string[] {carta.Id.ToString(),
                                                    carta.Nombre,
                                                    carta.Tipo,
                                                    carta.Habilidades,
                                                    carta.Rareza});
            }
        }


        public void BuscarPokemon(String param)
        {
            Cartas pokemon = new Cartas();

            List<Cartas> listPokemon = pokemon.getByName(param);
            dtPokemon.Rows.Clear();
            foreach (var itemPokemon in listPokemon)
            {
                Cartas carta = (Cartas)itemPokemon;
                dtPokemon.Rows.Add(new string[] {carta.Id.ToString(),
                                                    carta.Nombre,
                                                    carta.Tipo,
                                                    carta.Habilidades,
                                                    carta.Rareza});
            }
        }

        public void EliminarPokemon(String id)
        {
            Cartas pokemon = new Cartas();

            pokemon.BorrarPokemon(id);
            rellenarTabla();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debes rellenar el campo nombre");
                txtNombre.Focus();
            }
            else if (txtTipo.Text == "")
            {
                MessageBox.Show("Debes rellenar el campo tipo");
                txtTipo.Focus();
            }
            else if (txtHabilidades.Text == "")
            {
                MessageBox.Show("Debes rellenar el campo habilidades");
                txtHabilidades.Focus();
            }
            else if (txtRareza.Text == "")
            {
                MessageBox.Show("Debes rellenar el campo rareza");
                txtRareza.Focus();
            }
            else
            {
                Cartas poke = new Cartas();
                poke.Tipo = txtTipo.Text;
                poke.Nombre = txtNombre.Text;
                poke.Habilidades = txtHabilidades.Text;
                poke.Rareza = txtRareza.Text;

                poke.insertarDatos(poke);
                Console.WriteLine("Insertado");
                txtNombre.Text = "";
                txtTipo.Text = "";
                txtHabilidades.Text = "";
                txtRareza.Text = "";
                rellenarTabla();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            // Buscar por nombre o tipo
            BuscarPokemon(txtbuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener elementos seleccionados de datagridview
            Int32 selectedElementsCount = dtPokemon.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedElementsCount == 1)
            {
                // int index = int.Parse(dtPokemon.SelectedRows[0].Cells[0].Value.ToString());
                String index = dtPokemon.SelectedRows[0].Cells[0].Value.ToString();
                EliminarPokemon(index);
            }
            // Lanzar alerta si no hay elementos seleccionados
            else if (selectedElementsCount == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar un pokemon");
            }
            else if (selectedElementsCount > 1)
            {
                MessageBox.Show("Debe seleccionar solamente una fila para eliminar un pokemon");
            }
        }

        private void btIntercambio_Click(object sender, EventArgs e)
        {
            Intercambio intercambio = new Intercambio();
            intercambio.Show();
            this.Hide();
        }
        public void rellenarMazoUno()
        {
            Cartas pokemon = new Cartas();

            List<Cartas> listPokemon = pokemon.getMazo(1);
            //esto es para limpiar todas las filas de la tabla 
            dtMazo1.Rows.Clear();
            foreach (var itemPokemon in listPokemon)
            {
                Cartas carta = (Cartas)itemPokemon;
               //rows.add es para agregar una nueva fila con informacion a la datagridviwe
                dtMazo1.Rows.Add(new string[] {carta.Id.ToString(),
                                                    carta.Nombre,
                                                    carta.Tipo,
                                                    carta.Habilidades,
                                                    carta.Rareza});
            }
        }

        public void rellenarMazoDos()
        {
            Cartas pokemon = new Cartas();

            List<Cartas> listPokemon = pokemon.getMazo(2);
            dtMazo2.Rows.Clear();
            foreach (var itemPokemon in listPokemon)
            {
                Cartas carta = (Cartas)itemPokemon;
                dtMazo2.Rows.Add(new string[] {carta.Id.ToString(),
                                                    carta.Nombre,
                                                    carta.Tipo,
                                                    carta.Habilidades,
                                                    carta.Rareza});
            }
        }
        public void mazoUnoEnviar(String id)
        {
            Cartas pokemon = new Cartas();
            pokemon.crearEnMazo(id, 1);
            rellenarMazoUno();
        }

        public void mazoDosEnviar(String id)
        {
            Cartas pokemon = new Cartas();
            pokemon.crearEnMazo(id, 2);
            rellenarMazoDos();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Obtener elementos seleccionados de datagridview
            Int32 selectedElementsCount = dtPokemon.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedElementsCount == 1)
            {
                // int index = int.Parse(dtPokemon.SelectedRows[0].Cells[0].Value.ToString());
                String id = dtPokemon.SelectedRows[0].Cells[0].Value.ToString();
                mazoDosEnviar(id);
            }
            // Lanzar alerta si no hay elementos seleccionados
            else if (selectedElementsCount == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para enviar un pokemon al mazo");
            }
            else if (selectedElementsCount > 1)
            {
                MessageBox.Show("Debe seleccionar solamente una fila para enviar un pokemon al mazo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener elementos seleccionados de datagridview
            Int32 selectedElementsCount = dtPokemon.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedElementsCount == 1)
            {
                // int index = int.Parse(dtPokemon.SelectedRows[0].Cells[0].Value.ToString());
                String id = dtPokemon.SelectedRows[0].Cells[0].Value.ToString();
                mazoUnoEnviar(id);
            }
            // Lanzar alerta si no hay elementos seleccionados
            else if (selectedElementsCount == 0)
            {
                MessageBox.Show("Debe seleccionar una fila para enviar un pokemon al mazo");
            }
            else if (selectedElementsCount > 1)
            {
                MessageBox.Show("Debe seleccionar solamente una fila para enviar un pokemon al mazo");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioForm back = new InicioForm();
            back.Show();
        }
    }
}