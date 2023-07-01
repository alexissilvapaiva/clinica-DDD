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
   public class CrearCliente
    {
        private ClienteRepositorio repositorio;

        public CrearCliente(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(ClienteDTO cliente)
        {
            this.repositorio.Grabar(new Cliente(cliente.Id(), cliente.Nombre(), cliente.Apellido(), cliente.Email()));
        }
    }
}
