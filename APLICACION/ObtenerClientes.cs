using _01_APLICACION.DTO;
using _02_DOMINIO.Entidad;
using _02_DOMINIO.Repositorio;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _01_APLICACION
{
    public class ObtenerClientes
    {
        private ClienteRepositorio repositorio;

        public ObtenerClientes(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<ClienteDTO> Ejecutar()
        {
            List<Cliente> clientes = this.repositorio.ObtenerTodos();
            List<ClienteDTO> clientesDTO = new List<ClienteDTO>();
            foreach (Cliente cliente in clientes)
            {
                ClienteDTO clienteDTO = new ClienteDTO(cliente.Id(), cliente.Nombre(), cliente.Apellido(), cliente.Email());
                clientesDTO.Add(clienteDTO);
            }
            return clientesDTO;
        }
    }
}
