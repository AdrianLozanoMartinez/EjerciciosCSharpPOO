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

                if (persona is Cuenta)
                {
                    Cuenta personaCuenta = persona as Cuenta;
                    personaCuenta.Ingresar(1000);
                }
                if (persona is CuentaJoven)
                {
                    CuentaJoven personaCuentaJoven = persona as CuentaJoven;
                    personaCuentaJoven.Ingresar(1000);
                }

                
                Console.WriteLine(persona);
            }
       
           
        }
    }
}