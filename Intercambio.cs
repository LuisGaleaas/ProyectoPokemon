using ProyectoPokemon.mods;
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
    public partial class Intercambio : Form
    {
        public Intercambio()
        {
            InitializeComponent();
            rellenarMazoUno();
            rellenarMazoDos();

        }

        public void rellenarMazoUno()
        {
            Cartas pokemon = new Cartas();

            List<Cartas> listPokemon = pokemon.getMazo(1);
            dtMazo1.Rows.Clear();
            foreach (var itemPokemon in listPokemon)
            {
                Cartas carta = (Cartas)itemPokemon;
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
        public void intercambiar(String idOne, String idTwo)
        {
            Cartas pokemon = new Cartas();
            pokemon.intercambiarCartas(idOne, idTwo);
            rellenarMazoUno();
            rellenarMazoDos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Obtener elementos seleccionados de datagridview
            Int32 selectedElementsCountOne = dtMazo1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Int32 selectedElementsCountTwo = dtMazo2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedElementsCountOne == 1 & selectedElementsCountTwo == 1)
            {
                
                //Esto significa que estás accediendo a la primera fila seleccionada en esa tabla
                String idOne = dtMazo1.SelectedRows[0].Cells[0].Value.ToString();
                String idTwo = dtMazo2.SelectedRows[0].Cells[0].Value.ToString();
                intercambiar(idOne, idTwo);
            }
            // Lanzar alerta si no hay elementos seleccionados
            else if (selectedElementsCountOne == 0 | selectedElementsCountTwo == 0)
            {
                MessageBox.Show("Debe seleccionar una fila en ambos usuarios para intercambiar un pokemon");
            }
            else if (selectedElementsCountOne > 1 | selectedElementsCountTwo > 1)
            {
                MessageBox.Show("Debe seleccionar solamente una fila en ambos usuarios para intercambiar un pokemon");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioForm back = new InicioForm();
            back.Show();
        }
    }
}
