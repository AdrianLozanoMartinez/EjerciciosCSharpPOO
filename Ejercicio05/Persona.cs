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
        public string Dni { get => _dni; set => _dni = CalcularDNI(); }

        //Constructores
        public Persona(string nombre = "", int edad = 0, string dni = "")
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni; //dni sin letra
        }

        public override string ToString()
        {
            return $"{_edad}";
        }

        public string CalcularDNI()
        {
            Dni
            return "";
        }
    }
}
