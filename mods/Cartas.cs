using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;
using SQLitePCL;

namespace ProyectoPokemon.mods
{
    class Cartas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Habilidades { get; set; }
        public string Rareza { get; set; }
        public string rutaConexion { get; set; }

        public Cartas()
        {
           
            rutaConexion = @"Data Source =C:\Users\PC\Downloads\PROYECTO FINAL DE PROGRA\pokemondb.db";
        }

        public List<Cartas> getByName(String param)
        {

            List<Cartas> lista = new List<Cartas>();

            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                String consultaDatos = "SELECT * FROM Cartas where Nombre LIKE '%" + param + "%' OR Tipo LIKE '%" + param + "%' ";

                using (SqliteCommand command2 = new SqliteCommand(consultaDatos, connection))
                {
                    //SqliteDataReader es como el explorador que te permite leer
                    //la información dentro de esa base de datos
                    using (SqliteDataReader reader = command2.ExecuteReader())
                    {
                        //VERIFICAMOS SI TIENE FILAS LA CONSULTA
                        if (reader.HasRows)
                        {

                            //RECORREMOS LAS FILAS
                            while (reader.Read())
                            {
                                String nombreTemp = reader.GetString(reader.GetOrdinal("Nombre"));
                                Console.WriteLine($"Nombre Pokemon {nombreTemp}");
                                Cartas carta = new Cartas();
                                carta.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                carta.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                                carta.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                                carta.Habilidades = reader.GetString(reader.GetOrdinal("Habilidades"));
                                carta.Rareza = reader.GetString(reader.GetOrdinal("Rareza"));
                                lista.Add(carta);
                            }

                        }
                    }

                }
                connection.Close();
            }

            return lista;
        }

        public List<Cartas> getPokemo()
        {

            List<Cartas> lista = new List<Cartas>();

            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                String consultaDatos = "SELECT * FROM Cartas";

                using (SqliteCommand command2 = new SqliteCommand(consultaDatos, connection))
                {

                    using (SqliteDataReader reader = command2.ExecuteReader())
                    {
                        //VERIFICAMOS SI TIENE FILAS LA CONSULTA
                        if (reader.HasRows)
                        {

                            //RECORREMOS LAS FILAS
                            while (reader.Read())
                            {
                                String nombreTemp = reader.GetString(reader.GetOrdinal("Nombre"));
                                Console.WriteLine($"Nombre Pokemon {nombreTemp}");
                                Cartas carta = new Cartas();
                                carta.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                carta.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                                carta.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                                carta.Habilidades = reader.GetString(reader.GetOrdinal("Habilidades"));
                                carta.Rareza = reader.GetString(reader.GetOrdinal("Rareza"));
                                lista.Add(carta);
                            }

                        }
                    }

                }
                connection.Close();
            }

            return lista;
        }

        public List<Cartas> getMazo(int usuario)
        {

            List<Cartas> lista = new List<Cartas>();

            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                String consultaDatos = "SELECT Mazos.Id, Cartas.Nombre, Cartas.Tipo, Cartas.Habilidades, Cartas.Rareza FROM Cartas INNER JOIN Mazos ON Mazos.Id_Carta = Cartas.Id WHERE Mazos.Usuario = '" + usuario + "'";

                using (SqliteCommand command2 = new SqliteCommand(consultaDatos, connection))
                {

                    using (SqliteDataReader reader = command2.ExecuteReader())
                    {
                        //VERIFICAMOS SI TIENE FILAS LA CONSULTA
                        if (reader.HasRows)
                        {

                            //RECORREMOS LAS FILAS
                            while (reader.Read())
                            {
                                String nombreTemp = reader.GetString(reader.GetOrdinal("Nombre"));
                                Console.WriteLine($"Nombre Pokemon {nombreTemp}");
                                Cartas carta = new Cartas();
                                carta.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                carta.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                                carta.Tipo = reader.GetString(reader.GetOrdinal("Tipo"));
                                carta.Habilidades = reader.GetString(reader.GetOrdinal("Habilidades"));
                                carta.Rareza = reader.GetString(reader.GetOrdinal("Rareza"));
                                lista.Add(carta);
                            }

                        }
                    }

                }
                connection.Close();
            }

            return lista;
        }



        public void insertarDatos(Cartas cartaInsert)
        {
            //SqliteConnection es como la llave para abrir la puerta de tu base de datos SQLite.
            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                //SQLitePCL.raw.SetProvider es una instrucción que configura
                //el tipo específico de SQLite que tu programa utilizará
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                var consultaInsert = "INSERT INTO Cartas( Nombre, Tipo, Habilidades, Rareza) VALUES( @nombre, @tipo, @habilidades, @rareza);";
                using (SqliteCommand command = new SqliteCommand(consultaInsert, connection))
                {
                    //command.Parameters.AddWithValue("@id", cartaInsert.Id);
                    command.Parameters.AddWithValue("@nombre", cartaInsert.Nombre);
                    command.Parameters.AddWithValue("@tipo", cartaInsert.Tipo);
                    command.Parameters.AddWithValue("@habilidades", cartaInsert.Habilidades);
                    command.Parameters.AddWithValue("@rareza", cartaInsert.Rareza);
                    //el executeNonQuery es el comando que da la orden de hacer algo en la base de datos sin esperar obtener
                    //datos específico como respuesta
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");
                }



                connection.Close();
            }

        }

        public void crearEnMazo(String id, int usuario)
        {
            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                var consultaInsert = "INSERT INTO Mazos( Id_Carta, Usuario) VALUES( '" + id + "', '" + usuario.ToString() + "' );";
                using (SqliteCommand command = new SqliteCommand(consultaInsert, connection))
                {
                    command.ExecuteNonQuery();
                    if (usuario == 1)
                    {
                        MessageBox.Show("Carta enviada a mazo de usuario 1");
                    }
                    else
                    {
                        MessageBox.Show("Carta enviada a mazo de usuario 2");
                    }
                }



                connection.Close();
            }
        }

        public void intercambiarCartas(String idOne, String idTwo)
        {
            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();
                var consultaIntercambio1 = "UPDATE Mazos SET Usuario = '" + 2 + "'  WHERE Id = '" + idOne + "' ;";
                var consultaIntercambio2 = "UPDATE Mazos SET Usuario = '" + 1 + "'  WHERE Id = '" + idTwo + "' ;";
                using (SqliteCommand command = new SqliteCommand(consultaIntercambio1, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SqliteCommand command2 = new SqliteCommand(consultaIntercambio2, connection))
                {
                    command2.ExecuteNonQuery();
                }
                MessageBox.Show("El intercambio de pokemones ha sido exitoso!");
                connection.Close();
            }
        }

        public void BorrarPokemon(String id)
        {

            using (SqliteConnection connection = new SqliteConnection(this.rutaConexion))
            {
                SQLitePCL.raw.SetProvider(new SQLite3Provider_e_sqlite3());
                connection.Open();

                var consultaDelete = "DELETE FROM Cartas WHERE Id = '" + id + "' ";
                using (SqliteCommand command = new SqliteCommand(consultaDelete, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados");
                }

                connection.Close();
            }

        }

    }
}
