using System;

namespace PilaresdePOO
{
    class Aguila:Aves
    {
        public string tipoAguila { get; set; }
        public void VolarAlto()
        {
            Console.WriteLine("PARTICULARIDAD DEL ANIMAL: Vuela Alto");
        }
    }
}