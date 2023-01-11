namespace Ejercicio08
{
    class Program
    {
        static void Main()
        {
            //Empleado empleado = new Empleado(); //Se comprueba que no es accesible al ponerlo protegido

            Repartidor repartidor1 = new Repartidor("zona 3", "Lorena", 20, 1100);
            Repartidor repartidor2 = new Repartidor("zona 1", "Adri", 37, 900);
            Repartidor repartidor3 = new Repartidor("zona 3", "Marina", 28, 1300);
            Repartidor repartidor4 = new Repartidor("zona 2", "Aaron", 19, 500);

            Console.WriteLine(repartidor1);
            Console.WriteLine(repartidor2);
            Console.WriteLine(repartidor3);
            Console.WriteLine(repartidor4);

            Comercial comercial1 = new Comercial(500, "Eiden", 39, 1205);
            Comercial comercial2 = new Comercial(300, "Izan", 23, 520);
            Comercial comercial3 = new Comercial(159, "Lola", 57, 3500);
            Comercial comercial4 = new Comercial(250, "Bartolo", 30, 450);

            Console.WriteLine(comercial1);
            Console.WriteLine(comercial2);
            Console.WriteLine(comercial3);
            Console.WriteLine(comercial4);
        }
    }
}