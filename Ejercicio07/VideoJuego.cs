using System.Text;

namespace Ejercicio07
{
    class VideoJuego : IEntregable
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
            builder.AppendLine($"Título:              {Title}");
            builder.AppendLine($"Horas estimadas:     {Hours}");
            builder.AppendLine($"Género:              {Gender}");
            builder.AppendLine($"Compañía:            {Company}");
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
            return Hours.CompareTo(a.ToString());
        }
    }
}
