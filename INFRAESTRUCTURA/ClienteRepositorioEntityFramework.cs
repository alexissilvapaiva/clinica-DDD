using _02_DOMINIO;
using _02_DOMINIO.Entidad;
using _02_DOMINIO.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_INFRAESTRUCTURA
{
    public class ClienteRepositorioEntityFramework : ClienteRepositorio
    {
        public void ActualizarEmail(Guid id, string nuevoEmail)
            {
                using var baseDeDatos = new Contexto();
                var clienteEncontrado = baseDeDatos.Clientes.FirstOrDefault(cliente => cliente.id == id);
                if (clienteEncontrado != null)
                {
                    clienteEncontrado.email = nuevoEmail;
                    baseDeDatos.SaveChanges();
                }
                else
                {
                    return;
                }
            }

        public void Grabar(Cliente cliente)
        {
            using var baseDeDatos = new Contexto();
            baseDeDatos.Add(new ClienteEntity { id = cliente.Id(), nombre = cliente.Nombre(), apellido = cliente.Apellido(), email = cliente.Email() });
            baseDeDatos.SaveChanges();
        }

        public void EliminarCliente(Guid id)
        {
            using var baseDeDatos = new Contexto();
            var clienteEncontrado = baseDeDatos.Clientes.FirstOrDefault(cliente => cliente.id == id);
            if (clienteEncontrado != null)
            {
                baseDeDatos.Remove(clienteEncontrado);
                baseDeDatos.SaveChanges();
            }
            else
            {
                return;
            }
        }

        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> clientes = new List<Cliente>();
            using var baseDeDatos = new Contexto();
            var clientesEntity = baseDeDatos.Clientes;

            foreach (var i in clientesEntity)
            {
                Guid id = i.id;
                String nombre = i.nombre;
                String apellido = i.apellido;
                String email = i.email;
                Cliente cliente = new Cliente(id, nombre, apellido, email);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public Cliente ObtenerClientePorId(Guid id)
        {
            using var baseDeDatos = new Contexto();
            var dato = baseDeDatos.Clientes.FirstOrDefault(cliente => cliente.id == id);
            Cliente cliente = new Cliente(dato.id, dato.nombre, dato.apellido, dato.email);
            return cliente;
        }
    }
}
