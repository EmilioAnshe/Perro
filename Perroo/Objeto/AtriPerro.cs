using Objeto1;

namespace libreria{
    
    public class Perro{

        public string raza;
        public int edad;
        public string tamano;
        public void Jugar(string pJugar)
        {
            Console.WriteLine("Jugando....." + pJugar);
        }
        public string ladrar()
        {
            return "guau guau";
        }
    }
}




