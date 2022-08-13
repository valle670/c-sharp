using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno();
            d.Id = 2;
            d.PrimerNombre = "Maria";
            d.SegundoNombre = "Martinez";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Pedro";

            Alumno d = new Alumno ("Juan", "Jimenez");
        

            Console.WriteLine(a,Id);
            Console.WriteLine(b,Id);
            Console.WriteLine(c,Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}