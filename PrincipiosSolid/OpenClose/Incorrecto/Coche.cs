using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrecto
{
    // Establece que las entidades software (clases, módulos y funciones) deberían estar abiertos para su extensión,
    // pero cerrados para su modificación.
    public class Coche
    {
        private string marca;
        public string Marca { get; set; }
        public Coche(string marca) { this.marca = marca; }
        public string getMarcaCoche() { return marca; }
    }


}
