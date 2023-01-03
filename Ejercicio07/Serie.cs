using System.Text;

namespace Ejercicio07
{
    class Serie
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
            _title = title;
            _number = number;
            _gender = gender;
            _creator = creator;
        }
        public Serie(string title, string creator) : this (title, NUMBER, GENDER, creator) { }
        public Serie() : this (TITLE, NUMBER, GENDER, CREATOR) { }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Título:              {_title}");
            builder.AppendLine($"Número de temporada: {_number}");
            builder.AppendLine($"Género:              {_gender}");
            builder.AppendLine($"Creador:             {_creator}");
            builder.AppendLine($"Entregado:           {_delivered}");

            return builder.ToString();
        }
    }
}
