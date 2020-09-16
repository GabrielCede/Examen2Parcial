using System;

namespace PatronSingletonProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtenemos la instancia la cuál se crea por primera vez

            CSingleton uno = CSingleton.ObtenInstancia();

            //Hacemos algo con la instancia 
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();

            Console.WriteLine(uno);
            Console.WriteLine("-----------");


            //Obtenemos la 2da instancia 

            CSingleton dos = CSingleton.ObtenInstancia();

            //Comprobamos que es la misma instancia y si si es la misma instancia, tendrá el mismo estado.

            Console.WriteLine(dos);

            Console.ReadKey();

        }
        
    }
}
