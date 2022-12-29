namespace Ejercicio05
{
    class Program
    {
        static void Main()
        {
            Persona persona = new Persona("Adri", 37, "78979063");
            //Persona persona3 = new Persona("78979063");
            //Persona persona2 = new Persona();
            //persona.CalcularDNI();
            Console.WriteLine(persona);
            //Console.WriteLine(persona.Dni);
            //Console.WriteLine(persona.ToString());

            Cuenta cuenta = new Cuenta("Adri");
        }
    }
}