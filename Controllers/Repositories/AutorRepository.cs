using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using BibliotecaWebb.Models; // Agrega esta línea para importar el espacio de nombres de las clases de modelos
using BibliotecaWebb.Repositories;

namespace BibliotecaWebb.Repositories
{
    public class AutorRepository
    {
        private readonly string _connectionString;

        // Nuevo constructor que acepta la cadena de conexión directamente
        public AutorRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public IEnumerable<Autor> ObtenerTodos()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = "SELECT * FROM Autores";
                return connection.Query<Autor>(sql);
            }
        }

        public void AgregarNuevo(string nombre)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                    var sql = "INSERT INTO Autores (Nombre) VALUES (@Nombre)";
                    int rowsAffected = connection.Execute(sql, new { Nombre = nombre });

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Autor agregado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo agregar el autor");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al agregar el autor: {ex.Message}");
                }

            }
        }
    }
}

