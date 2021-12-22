using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrecto
{
    class Principal
    {
        public static void main(String[] args)
        {
            Coche[] arrayCoches = {
            new Coche("Renault"),
            new Coche("Audi")
            };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.marca == "Renault") Console.Out.WriteLine(18000);
                if (coche.marca == "Audi") Console.Out.WriteLine(25000);
            }
        }
    }
}
