using _02_DOMINIO.ValueObject;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _02_DOMINIO.Entidad
{
    public class Cliente
    {
        private Identificador id;
        private Nombre nombre;
        private Apellido apellido;
        private Email email;

        public Cliente(
            Guid id, 
            String nombre, 
            String apellido, 
            String email
        )
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.email = new Email(email);
        }

        public Guid Id()
        {
            return this.id.Valor();
        }
        public String Nombre()
        {
            return this.nombre.Valor();
        }
        public String Apellido()
        {
            return this.apellido.Valor();
        }
        public String Email()
        {
            return this.email.Valor();
        }
        public void CambiarEmail(String nuevoEmail)
        {
            this.email = new Email(nuevoEmail);
        }
    }
}
