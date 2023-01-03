using System.Text;

namespace Ejercicio07
{
    class Serie : IEntregable 
    {
        //Constantes
        private const int NUMBER = 3;
        private const bool DELIVERED = false;
        private const string TITLE = "";
        private const string GENDER = "";
        private const string CREATOR = "";

        //Atributos
        private string _title; //título
        private int _number; //número de temporadas
        private bool _delivered; //entregado
        private string _gender; //género
        private string _creator; //creador

        //Propiedades
        public string Title { get => _title; set => _title = value; } 
        public int Number { get => _number; set => _number = value; } 
        public string Gender { get => _gender; set => _gender = value; } 
        public string Creator { get => _creator; set => _creator = value; }

        //Constructores
        public Serie(string title, int number, string gender, string creator) 
        {
            Title = title;
            Number = number;
            Gender = gender;
            Creator = creator;
        }
        public Serie(string title, string creator) : this (title, NUMBER, GENDER, creator) { }
        public Serie() : this (TITLE, NUMBER, GENDER, CREATOR) { }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Título:              {Title}");
            builder.AppendLine($"Número de temporada: {Number}");
            builder.AppendLine($"Género:              {Gender}");
            builder.AppendLine($"Creador:             {Creator}");
            builder.AppendLine($"Entregado:           {_delivered}");

            return builder.ToString();
        }

        public bool Entregar()
        {
            _delivered = true;
            return _delivered;
        }

        public bool Devolver()
        {
            _delivered = false;
            return _delivered;
        }

        public bool EsEntregado()
        {
            bool condition;

            if (_delivered == true)
                condition = true;
            else
                condition = false;

            return condition;
        }

        public int CompareTo(object a)
        {
            int estado = -1;

            //Hacemos un casting de objetos para usar el metodo get
            Serie serie = a as Serie;

            //Si lo que ya estaba serie[i] o Number es mayor que lo que metemos en parámetro serieMayor o serie.Number
            if (Number > serie.Number) //Aquí elegimos el tipo de comparación, podemos hacer que serie[i] en lugar de mayor sea menor u otra condición
            {
                estado = 1; //El estado que devuelve, ya que CompareTo devuelve 1,0,-1
                /* 1:  La serie[i] es mayor que la serieMayor
                 * 0:  Las Series son iguales
                 * -1: La serie[i] es menor que la serieMayor*/
            }
            else if (Number == serie.Number)
            {
                estado = 0;
            }

            return estado;
        }
    }
}
