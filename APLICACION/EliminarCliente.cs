using _02_DOMINIO.Repositorio;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _01_APLICACION
{
   public class EliminarCliente
    {
        private ClienteRepositorio repositorio;
        public EliminarCliente(ClienteRepositorio repositorio) 
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(Guid id)
        {
            this.repositorio.EliminarCliente(id);
        }
    }
}
