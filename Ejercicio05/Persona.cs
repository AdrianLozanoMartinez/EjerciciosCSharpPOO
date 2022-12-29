using System.Text;
using System.Xml.Linq;

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
        public Persona(string nombre = "", int age = 0, string dni = "")
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
            StringBuilder builder = new StringBuilder(); //Igual que $"Tiene de IMC: \n

            builder.AppendLine($"Nombre: {_name}"); //Se usa atributo porque la propiedad es solo escritura sino seria propiedad
            builder.AppendLine($"Edad: {_age}");
            builder.AppendLine($"DNI: {_dni}");

            return builder.ToString();
        }

        public string CalcularDNI(string dni)
        {
            char letter = ' ';

            try
            {
                int DniNumber = int.Parse(dni);
                letter = LETTERS[DniNumber % LETTERS.Length];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dni + letter;
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
