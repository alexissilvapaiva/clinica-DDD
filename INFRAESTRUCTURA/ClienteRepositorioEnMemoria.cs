using _02_DOMINIO.Entidad;
using _02_DOMINIO.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_INFRAESTRUCTURA
{
    public class ClienteRepositorioEnMemoria : ClienteRepositorio
    {
        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> ObtenerTodos()
        {
            return this.clientes;
        }

        public void ActualizarEmail(Guid id, string nuevoEmail)
        {
            Cliente clienteEncontrado = this.ObtenerClientePorId(id);
            clienteEncontrado.CambiarEmail(nuevoEmail);
        }

        public void Grabar(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }

        public void EliminarCliente(Guid id)
        {
            this.clientes.RemoveAll(c => c.Id() == id);
        }

        public Cliente ObtenerClientePorId(Guid id)
        {
            Cliente clienteEncontrado = this.clientes.Find(cliente => cliente.Id() == id);
            return clienteEncontrado;
        }
    }
}
