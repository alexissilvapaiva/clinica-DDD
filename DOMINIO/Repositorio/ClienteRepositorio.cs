using _02_DOMINIO.Entidad;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _02_DOMINIO.Repositorio
{
    public interface ClienteRepositorio
    {
        public List<Cliente> ObtenerTodos();
        public void Grabar(Cliente cliente);
        public void EliminarCliente(Guid id);
        public void ActualizarEmail(Guid id, String nuevoEmail);
        public Cliente ObtenerClientePorId(Guid id);
    }
}
