using System.Text;

namespace Ejercicio05
{
    class Persona
    {
        //Constante
        const string LETTERS = "trwagmyfpdxbnjzsqvhlcke";

        //Atributos
        private string _name;
        private int _age;
        private string _dni;

        //Propiedades
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Dni { get => _dni; set => _dni = value; }
        //public string Dni { get => _dni; set => _dni = CalcularDNI(); }

        //Constructores
        public Persona(string nombre = "", int age = 0, int dni = 0)
        {
            Name = nombre;
            Age = age;
            //Dni = dni; //dni sin letra
            Dni = CalcularDNI(dni);
        }

        //Métodos
        public override string ToString()
        {
            //Se puede hacer $"fff\n" pero es otro modo
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Nombre: {Name}");
            builder.AppendLine($"Edad: {Age}");
            builder.AppendLine($"DNI: {Dni}");

            return builder.ToString();
        }

        public string CalcularDNI(int dni)
        {
            char letter = ' ';

            try
            {
                letter = LETTERS[dni % LETTERS.Length];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return $"{dni} {letter}";
        }

        public bool EsMayorDeEdad()
        {
            bool isHigher = false;

            if (_age >= 18)
            {
                isHigher = true;
            }

            return isHigher;
        }
    }
}
