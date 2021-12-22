using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Correcto
{
    // Establece que las entidades software (clases, módulos y funciones) deberían estar abiertos para su extensión,
    // pero cerrados para su modificación.
    public abstract class Coche
    {
        public abstract int precioMedioCoche();
    }
}
