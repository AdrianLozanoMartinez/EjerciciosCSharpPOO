using System.Diagnostics.Metrics;
using System.Text;
using System.Xml.Linq;

namespace Ejercicio02
{
    //enum sexo { Hombre, Mujer } //Si se deja ahí se llama directamente como sexo y no como persona.sexo como abajo public
    class Persona
    {
        public enum sexo { Hombre, Mujer };  //se llama en el Program como persona.sexo y no directamente sexo como arriba

        //Constantes
        private const sexo SEXO = sexo.Hombre;
        public const int IDEAL = 0;
        public const int THIN = -1;
        public const int OBESE = 1;
        const string LETTERS = "trwagmyfpdxbnjzsqvhlcke";

        //Atributos
        private string _name;
        private int _age;
        private string _dni;
        private double _weight;
        private sexo _sexo;
        private double _height;

        //Propiedades
        public string Name { set => _name = value; }
        public int Age { set => _age = value; }
        public double Weight { set => _weight = value; }
        public sexo Sexo { set => _sexo = value; }
        public double Height { set => _height = value; }


        //Constructores
        public Persona(string name, int age, double weight, sexo sexo, double height)
        {
            Name = name;
            Age = age;
            Sexo = sexo;
            Weight = weight;
            Height = height;
            _dni = GeneraDNI(); //Porque se genera el dato
        }
        public Persona(string name, int age, sexo sexo) : this (name, age, 0, sexo, 0){}
        public Persona() : this (string.Empty, 0, SEXO){}

        //Métodos
        public int CalcularIMC()
        {
            double result = _weight / Math.Pow(_height,2);
            int imc = IDEAL;

            if(result < 20)
            {
                imc = THIN;
            }
            else if(result > 25)
            {
                imc = OBESE;
            }
            return imc; 
        }

        public bool EsMayorDeEdad()
        {
            return _age >= 18;
        }

        public override string ToString()
        {
            //Se puede hacer $"fff\n" pero es otro modo
            StringBuilder builder = new StringBuilder(); //Igual que $"Tiene de IMC: \n

            builder.AppendLine($"Nombre: {_name}"); //Se usa atributo porque la propiedad es solo escritura sino seria propiedad
            builder.AppendLine($"Edad: {_age}");
            builder.AppendLine($"Sexo: {_sexo}");
            builder.AppendLine($"DNI: {_dni}");
            builder.AppendLine($"Peso: {_weight}");
            builder.AppendLine($"Altura: {_height}");

            return builder.ToString();
        }

        //1º Opción
        private string GeneraDNI()
        {
            Random random = new Random();

            string num = "";
            //string[] array = new string[8];

            for (int i = 0; i < 8; i++)
            {
                num += random.Next(0, 10);
            }

            int result = int.Parse(num);

            char letter = LETTERS[result % LETTERS.Length]; //o 23

            return $"DNI: {num}{letter}";
        }

        //2º Opción
        /*private string GenerarDNI()
        {
           /* int numero = GenerarNumeroAleatorio();
            char letra = LETTERS[numero % LETTERS.Length];

            return numero.ToString() + letra;
        }

        private int GenerarNumeroAleatorio()
        {
            Random random = new Random();

            return random.Next(1, 100000000);
        }*/
    }
}
