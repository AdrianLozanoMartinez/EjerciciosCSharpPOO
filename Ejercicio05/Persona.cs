using System.Text;
using System.Xml.Linq;

namespace Ejercicio05
{
    class Persona
    {
        //Constante
        const string LETTERS = "trwagmyfpdxbnjzsqvhlcke";

        //Atributos
        private string _nombre;
        private int _edad;
        private string _dni;

        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Dni { get => _dni; set => _dni = value; }
        //public string Dni { get => _dni; set => _dni = CalcularDNI(); }

        //Constructores
        public Persona(string nombre = "", int edad = 0, string dni = "")
        {
            Nombre = nombre;
            Edad = edad;
            //Dni = dni; //dni sin letra
            Dni = CalcularDNI(dni); 
        }

        public override string ToString()
        {
            //Se puede hacer $"fff\n" pero es otro modo
            StringBuilder builder = new StringBuilder(); //Igual que $"Tiene de IMC: \n

            builder.AppendLine($"Nombre: {_nombre}"); //Se usa atributo porque la propiedad es solo escritura sino seria propiedad
            builder.AppendLine($"Edad: {_edad}");
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
    }
}
