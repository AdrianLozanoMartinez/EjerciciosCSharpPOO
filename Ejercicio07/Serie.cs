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
            return true;
        }

        public bool Devolver()
        {
            return false;
        }

        public bool EsEntregado()
        {
            bool condition;

            if (Devolver())
                condition = false;
            else 
                condition = true;

            return condition;
        }

        public int CompareTo(object a)
        {
            return Number.CompareTo(a.ToString());
        }
    }
}
