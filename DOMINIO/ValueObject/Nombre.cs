using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DOMINIO.ValueObject
{
    public class Nombre
    {
        private String valor;

        public Nombre(String valor)
        {
            this.DebeContenerMasDe4Caracteres(valor);
            this.DebeContenerMenosDe20Caracteres(valor);
            this.NoPuedeEstarVacio(valor);
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeContenerMasDe4Caracteres(String valor)
        {
            if (valor.Length < 4)
            {
                throw new ArgumentException("El nombre debe contener, al menos, 4 caracteres.");
            }
        }

        private void DebeContenerMenosDe20Caracteres(String value)
        {
            if (value.Length > 20)
            {
                throw new ArgumentException("El nombre debe contener un máximo de 20 caracteres.");
            }
        }

        private void NoPuedeEstarVacio(String value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }
    }
}
