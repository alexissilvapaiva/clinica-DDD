using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_DOMINIO.ValueObject
{
   public class Email
    {
        private String valor;

        public Email(String valor)
        {
            this.DebeTenerSintaxisValida(valor);
            this.NoPuedeEstarVacio(valor);
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeTenerSintaxisValida(String valor)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            if (!regex.IsMatch(valor))
            {
                throw new ArgumentException("El email no es válido.");
            }
        }

        private void NoPuedeEstarVacio(String value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El email no puede estar vacío."); 
            }
        }
    }
}
