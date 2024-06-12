using System;

using libreria;

namespace Objeto1{

    public class Principal{

        public static void Main()
        {
            string nombre;


            nombre = "Juan";
            Perro Firulais= new Perro();
            Perro pedro = new Perro();


            Console.WriteLine("hola");

            Firulais.edad = 2;

            Firulais.tamano = "Grande";

            Firulais.raza = "caniche";

            Firulais.ladrar();

            Firulais.Jugar("Saltar");
            Firulais.Jugar("dormirse");

        }
    }
}