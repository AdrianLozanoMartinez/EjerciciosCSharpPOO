namespace Ejercicio06
{
    class CompactDisc
    {
        private Cancion[] _songs;
        private int _accountant;

        public int NumSongs { get => _accountant; set => _accountant = value; }

        public CompactDisc(int tamano)
        {
            _songs = new Cancion[tamano];
            _accountant = 0;
        }

        public Cancion ObtenerCancion(int song)
        {
            return _songs[song];
        }

        public void Agregar(Cancion song)
        {
            if (_accountant >= _songs.Length)
                Console.WriteLine("No se puede agregar más, has pasado el límite");

            else
            {
                _songs[_accountant] = song;
                _accountant++;
            }
        }

        public void Eliminar()
        {
            
        }
    }
}
