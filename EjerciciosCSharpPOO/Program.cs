using Ejercicio01;

namespace EjerciciosCSharpPOO
{
    class Program
    {
        static void Main()
        {
            Cuenta cuenta1 = new Cuenta("Aarón");
            Cuenta cuenta2 = new Cuenta("Marina", 1025);

            cuenta1.Ingresar(100);
            cuenta2.Ingresar(100);

            cuenta1.Retirar(5);
            cuenta2.Retirar(250);

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}