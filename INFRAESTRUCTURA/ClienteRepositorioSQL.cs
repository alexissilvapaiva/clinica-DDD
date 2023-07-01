using _02_DOMINIO.Entidad;
using _02_DOMINIO.Repositorio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_INFRAESTRUCTURA
{
    public class ClienteRepositorioSQL : ClienteRepositorio
    {
        String connectionString = "Data Source=DESKTOP-CMEJDLF\\SQLEXPRESS01;Initial Catalog=ClinicaVeterinaria;Integrated Security=True; Encrypt=False";
        //String connectionString = "Data Source=SYS\\VET;Initial Catalog=ClinicaVeterinaria;Integrated Security=True; Encrypt=False";
        
        public void ActualizarEmail(Guid id, String nuevoEmail)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("UPDATE clientes SET email=@email WHERE id=@id", conexion))
                {
                    command.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = id;
                    command.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = nuevoEmail;
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }          
        }

        public void EliminarCliente(Guid id)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM clientes WHERE id=@id", conexion))
                {
                    command.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = id;
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void Grabar(Cliente cliente)
        {
            using(SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO clientes (id, nombre, apellido, email) VALUES (@id, @nombre, @apellido, @email)", conexion))
                {
                    command.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = cliente.Id();
                    command.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = cliente.Nombre();
                    command.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar).Value = cliente.Apellido();
                    command.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = cliente.Email();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public List<Cliente> ObtenerTodos()
        {
                List<Cliente> clientes = new List<Cliente>();
                using (SqlConnection conexion = new SqlConnection(this.connectionString))
                {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, nombre, apellido, email FROM clientes", conexion))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid id = reader.GetGuid(0);
                            String nombre = reader.GetString(1);
                            String apellido = reader.GetString(2);
                            String email = reader.GetString(3);
                            Cliente cliente = new Cliente(id, nombre, apellido, email);
                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }

        public Cliente ObtenerClientePorId(Guid _id)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, nombre, apellido, email FROM clientes WHERE id=@id", conexion))
                {
                    command.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = _id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Guid id = reader.GetGuid(0);
                        String nombre = reader.GetString(1);
                        String apellido = reader.GetString(2);
                        String email = reader.GetString(3);
                        Cliente cliente = new Cliente(id, nombre, apellido, email);

                        return cliente;
                    }
                }
            }
        }
    }
}
