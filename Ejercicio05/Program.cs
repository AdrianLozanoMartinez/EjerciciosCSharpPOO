namespace Ejercicio05
{
    class Program
    {
        //const int POSICION = 5;
        static void Main()
        {
           /* Persona[] personas = new Persona[POSICION];

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

                if (persona is Cuenta)
                {
                    Cuenta personaCuenta = persona as Cuenta;
                    personaCuenta.Ingresar(1000);
                }
                else if (persona is CuentaJoven)
                {
                    CuentaJoven personaCuentaJoven = persona as CuentaJoven;
                    personaCuentaJoven.Ingresar(50);
                }

                
                Console.WriteLine(persona);
            }*/
       
           Persona maria = new Persona("María", 20, 123456789);
           Persona pedro = new Persona("Pedro", 40, 987654321);

           Cuenta cuentaPedro = new Cuenta("Pedro");

           CuentaJoven cuentaJovenMaria = new CuentaJoven("Maria");
           CuentaJoven cuentaJovenPedro = new CuentaJoven("Pedro");

            //CuentaJoven cuentaJovenPedro = new CuentaJoven("Pedro", 40, 987654321);


            Console.WriteLine(maria);
           Console.WriteLine(pedro);

           Console.WriteLine();

           cuentaPedro.Ingresar(1000);
           cuentaPedro.Retirar(502);
           Console.WriteLine(cuentaPedro);

           Console.WriteLine();

           cuentaJovenMaria.Ingresar(90);
           cuentaJovenMaria.Retirar(200);
           Console.WriteLine(cuentaJovenMaria);

           cuentaJovenPedro.Ingresar(80);
           cuentaJovenPedro.Retirar(5);
           Console.WriteLine(cuentaJovenPedro);
        }
    }
}