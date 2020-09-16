using System;
using System.Collections.Generic;
using System.Text;

namespace PatronSingletonProyecto
{
    class CSingleton
    {
        //Aquí guardamos la única instancia que va a existir 
        private static CSingleton instancia;


        //Datos propios de la clase
        private string nombre;
        private int edad;


        //Creamos el constructor privado 
         private CSingleton()
        {
            nombre = "Sin asignar";
            edad = 99;
        }
         
    public static CSingleton ObtenInstancia()
        {
            //Verificamos si no existe la instancia 
            if (instancia==null)
            {
                //Si no existe, instanciamos
                instancia = new CSingleton();

                Console.WriteLine("====Instancia Creada por primera vez====");
            }

            //Retornamos la instancia 
            return instancia;

        }

        //Creamos los método propios de la clase

        public override string ToString()
        {
            return string.Format("La persona {0}, tiene edad de {1}",nombre, edad);
        }
        public void PonerDatos (String xNombre, int xEdad)
        {
            nombre = xNombre;
            edad = xEdad;
        }

        //Esto representa cualquier otro objeto
        public void AlgunProceso()
        {
            Console.WriteLine("{0} está realizando actividades", nombre);
        }

    }
}
