using System.Text;

namespace Ejercicio07
{
    class VideoJuego
    {
        //Constantes
        private const int HOURS = 10;
        private const bool DELIVERED = false;
        private const string TITLE = "";
        private const string GENDER = "";
        private const string COMPANY = "";

        //Atributos
        private string _title;
        private int _hours;
        private bool _delivered;
        private string _gender;
        private string _company;

        //Propiedades
        public string Title { get => _title; set => _title = value; }
        public int Hours { get => _hours; set => _hours = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Company { get => _company; set => _company = value; }

        //Constructores
        public VideoJuego(string _title, int _hours, string _gender, string _company) { }
        public VideoJuego(string _title, int _hours) : this (_title, _hours, GENDER, COMPANY) { }
        public VideoJuego() : this (TITLE, HOURS) { }

        //Métodos
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Título:              {_title}");
            builder.AppendLine($"Horas estimadas:     {_hours}");
            builder.AppendLine($"Género:              {_gender}");
            builder.AppendLine($"Compañía:            {_company}");
            builder.AppendLine($"Entregado:           {_delivered}");

            return builder.ToString();
        }
    }
}
