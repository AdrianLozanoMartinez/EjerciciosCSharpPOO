namespace Ejercicio06
{
    class Cancion
    {
        //Atributos
        private string _title;
        private string _author;

        //Propiedades
        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }

        //Constructor
        public Cancion(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
