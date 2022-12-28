namespace Ejercicio03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Indica una cantidad de contraseñas");
            int cant = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la longitud de la contraseña");
            int length = int.Parse(Console.ReadLine());

            Password[] passwords = new Password[cant];

            bool[] isStrong = new bool[passwords.Length];

            for (int i = 0; i < passwords.Length; i++)
            {
                //Creamos una instancia por cada vuelta del for, con la longitud marcada (length) la longitud que se encuentra en el método de la contraseña llamada desde el constructor
                passwords[i] = new Password(length); //Mandamos al constructor la longitud

                //Resultado de comprobar en la clase si es fuerte
                isStrong[i] = passwords[i].EsFuerte(); //Cogemos el password creado y lo probamos en el método

                Console.WriteLine($"{passwords[i].PasswordProperty} {isStrong[i]}");
                                                //Propiedad que se lee porque ya se mete en el atributo la contraseña a través del método llamadod esde el constructor y luego desde el for
            }




          
        }
    }
}