using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon l = new Leon();
            Console.WriteLine("--------");
            Console.WriteLine("- Leon -");
            Console.WriteLine("--------");
            l.Nombre = "Leonardo";
            l.Patas = 4;
            l.Pelaje = "Melena larga, macho dominante";
            l.Raza = "Africana";
            l.Comer();
            l.Caminar();
            l.Rugir();
            l.EsFurioso = true;

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.Pelaje);
            Console.WriteLine(l.Raza);         

            Console.WriteLine();

            Vaca v = new Vaca();
            Console.WriteLine("--------");
            Console.WriteLine("- Vaca -");
            Console.WriteLine("--------");
            v.Nombre = "Vaquita";
            v.Patas = 4;
            v.Comer();
            v.HaceMooo = true;
            v.Caminar();

            Console.WriteLine(v.Nombre);
            Console.WriteLine(v.Patas);

            Console.WriteLine();

            Condor c = new Condor();
            Console.WriteLine("----------");
            Console.WriteLine("- Condor -");
            Console.WriteLine("----------");
            c.Nombre = "Condor";
            c.Patas = 2;
            c.Incubacion = 30;
            c.ColorPlumaje = "no tiene pelo en la cabeza blanco y negro";
            c.Volar();
            c.Comer();
            c.Hacerreir();

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Incubacion);
            Console.WriteLine(c.Patas);
            Console.WriteLine(c.ColorPlumaje);

            Console.WriteLine();

            PapaGallo P = new PapaGallo();
            Console.WriteLine("--------------");
            Console.WriteLine("- PapaGallo  -");
            Console.WriteLine("--------------");
            

            Console.WriteLine();

            PezAzul d = new PezAzul();
            Console.WriteLine("------------");
            Console.WriteLine("- Pez Azul -");
            Console.WriteLine("------------");
            d.Nombre = "Dory";
            d.NumeroAletas = 2;
            d.Comer();
            d.Nadar();
            d.Color = "es de color azul con negro";
            d.PerderMermoria();
            d.MemoryLost();

            Console.WriteLine(d.Nombre);
            Console.WriteLine(d.NumeroAletas);
            Console.WriteLine(d.Color);

            Tiburon t = new Tiburon();
            Console.WriteLine("--------------");
            Console.WriteLine("- Tiburon -");
            Console.WriteLine("--------------");
            t.Nombre = "Tiburon";
            t.NumeroAletas = 2;
            t.Comer();
            t.Nadar();
            t.Color = "Gris con Blanco";
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            }
        }
}