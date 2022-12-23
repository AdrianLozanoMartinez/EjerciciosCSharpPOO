using Ejercicio01;

namespace EjerciciosCSharpPOO
{
    class Program
    {
        static void Main()
        {
            Cuenta cuenta1 = new Cuenta("Adri");
            Cuenta cuenta2 = new Cuenta("Marina", 1000);

            cuenta1.Ingresar(1000);
            cuenta2.Ingresar(500);

            cuenta1.Retirar(100);
            cuenta2.Retirar(52);

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}