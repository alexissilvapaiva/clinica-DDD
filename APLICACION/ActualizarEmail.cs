using _02_DOMINIO.Repositorio;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _01_APLICACION
{
    public class ActualizarEmail
    {
        private ClienteRepositorio repositorio;

        public ActualizarEmail(ClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(Guid id, String nuevoEmail) 
        {
            this.repositorio.ActualizarEmail(id, nuevoEmail);
        }
    }
}

