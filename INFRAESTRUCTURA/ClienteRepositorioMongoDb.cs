using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_DOMINIO.Entidad;
using _02_DOMINIO.Repositorio;
using _03_INFRAESTRUCTURA.SchemasMongo;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _03_INFRAESTRUCTURA
{
    public class ClienteRepositorioMongoDb : ClienteRepositorio
    {

        private IMongoCollection<ClienteSchema> Conexion()
        {
            const string connectionUri = "mongodb://localhost:27017";
            const string dbName = "ClinicaVeterinaria";
            var client = new MongoClient(connectionUri);
            var db = client.GetDatabase(dbName);
            var collection = db.GetCollection<ClienteSchema>("clientes");
            return collection;
        }

        public void ActualizarEmail(Guid id, string nuevoEmail)
        {
            IMongoCollection<ClienteSchema> coleccionClientes = Conexion();
            coleccionClientes.UpdateOne(cliente => cliente.Id == id, Builders<ClienteSchema>.Update.Set(cliente => cliente.Email, nuevoEmail));
        }

        public void EliminarCliente(Guid id)
        {
            IMongoCollection<ClienteSchema> coleccionClientes = Conexion();
            coleccionClientes.DeleteOne(cliente => cliente.Id == id);
        }

        public void Grabar(Cliente cliente)
        {
            IMongoCollection<ClienteSchema> clienteMongoDB = Conexion();
            clienteMongoDB.InsertOne(new ClienteSchema{ Id = cliente.Id(), Nombre = cliente.Nombre(), Apellido = cliente.Apellido(), Email = cliente.Email()});
        }

        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            IMongoCollection<ClienteSchema> coleccionClientes = Conexion();
            var clientesEnDB = coleccionClientes.Find(_ => true);

            foreach (var i in clientesEnDB.ToList())
            {
                Guid id = new Guid(i.Id.ToString());
                String nombre = i.Nombre;
                String apellido = i.Apellido;
                String email = i.Email;
                Cliente cliente = new Cliente(id, nombre, apellido, email);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public Cliente ObtenerClientePorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
