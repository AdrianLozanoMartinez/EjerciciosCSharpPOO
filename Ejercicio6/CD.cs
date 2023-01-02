namespace Ejercicio06
{
    class CD
    {
        //Atributos
        private object[] _songs; 
        private int _count;

        //Porpiedades
        public int NumberSongs { get => _count; }

        //Constructor
        public CD(int tamano)
        {
            _songs[NumberSongs] = _songs[tamano];
        }

        //Métodos
        public object DameCancion(string song)
        {
            for (int i = 0; i < _songs.Length; i++)
            {
                if (_songs[i] == song)
                    song += _songs[i];
            }
            return song;
        }

        public object Agrega(object song)
        {
            for (int i = 0; i < _songs.Length; i++)
            {
                if (i >= _songs.Length)
                {
                    Console.WriteLine("Ya está llevo el disco");
                }
                else
                {
                    _songs[i] = song;
                }
            }
            return _songs;
        }

        public object[] Elimina(int song)
        {
            for (int i = 0; i < _songs.Length; i++)
            {
                if (_songs[i] == _songs[song])
                _songs[i] = "";
            }
            return _songs;
        }


    }
}
