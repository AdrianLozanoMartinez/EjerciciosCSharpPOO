namespace Ejercicio05
{
    class Program
    {
        const int POSICION = 5;
        static void Main()
        {
            Persona[] personas = new Persona[POSICION];

            personas = new Persona[POSICION]
            {
                new Persona("María", 20, 123456789),
                new Persona("Pedro", 40, 987654321),
                new Cuenta("Pedro"),
                new CuentaJoven("Pedro"),
                new CuentaJoven("María")
            };

            foreach (Persona persona in personas)
            {
                if (persona is Persona) 
                    persona.
                pedroCuenta.Ingresar(1000);
                PedroJoven.Ingresar(500);
                MariaJoven.Ingresar(2000);

                precioElectrodomesticos += electrodomestico.PrecioBase;

                if (electrodomestico is Lavadora)
                    precioLavadora += electrodomestico.PrecioBase;
                else if (electrodomestico is Television)
                    precioTelevision += electrodomestico.PrecioBase;
            }
            Console.WriteLine($"Precio total electrodomésticos: {precioElectrodomesticos}");
            Console.WriteLine($"Precio total lavadoras: {precioLavadora}");
            Console.WriteLine($"Precio total Televisión: {precioTelevision}");


            

            Console.WriteLine(pedroCuenta);
            Console.WriteLine(PedroJoven);
            Console.WriteLine(MariaJoven);

        }
    }
}