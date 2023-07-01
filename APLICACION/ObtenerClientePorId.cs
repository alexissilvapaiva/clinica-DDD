using _02_DOMINIO.Repositorio;
using _02_DOMINIO.Entidad;
using _01_APLICACION.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_APLICACION
{
    public class ObtenerClientePorId
    {
        private ClienteRepositorio repositorio;

        public ObtenerClientePorId(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public ClienteDTO Ejecutar(Guid id)
        {
            Cliente clienteEncontrado = this.repositorio.ObtenerClientePorId(id);
            this.ValidarCliente(clienteEncontrado);
            ClienteDTO clienteEncontradoDTO = new(clienteEncontrado.Id(), clienteEncontrado.Nombre(), clienteEncontrado.Apellido(), clienteEncontrado.Email());

            return clienteEncontradoDTO;
        }

        public void ValidarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException("No se encontró el cliente.");
            }
        }
    }
}
