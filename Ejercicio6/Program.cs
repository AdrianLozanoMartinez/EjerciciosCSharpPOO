namespace Ejercicio06
{
    class Program
    {
        static void Main()
        {
            Cancion cancion1 = new Cancion("Take on me de A-ha");
            //Cancion cancion2 = new Cancion("Africa de Toto", "");
            //Cancion cancion3 = new Cancion("Don't stop believin de Journey", "");

            CD cd = new CD(2);

            cd.Agrega(cancion1);

            cd.Elimina(1);
            cd.Elimina(0);

            Console.WriteLine(cd.NumberSongs);

            //cd.Agrega(cancion2);
            //cd.Agrega(cancion3);

            Console.WriteLine(cd.NumberSongs);

            //Console.WriteLine(Cancion._title + '' + Cancion._author);
        }
    }
}