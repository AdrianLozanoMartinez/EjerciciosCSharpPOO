namespace Ejercicio07
{
    class Program
    {
        static void Main()
        {
            Serie[] series = new Serie[5];
            VideoJuego[] videoJuegos = new VideoJuego[5];

            series[0] = new Serie("The walking dead", 11, "Horror", "Robert Kirkman");
            series[1] = new Serie("Doctor who", 26, "Ciencia ficción", "Webber Donald Wilson");
            series[2] = new Serie("Invasión jurásica", 5, "Ciencia ficción", "Adrien Hodges");
            series[3] = new Serie("Dragon ball","Akira Toriyama");
            series[4] = new Serie();

            videoJuegos[0] = new VideoJuego("Resident evil", 60, "Horror", "Capcom");
            videoJuegos[1] = new VideoJuego("Final fantasy VIII", 100, "Ciencia ficción", "Square Enix");
            videoJuegos[2] = new VideoJuego("Silent hill 2", 25, "Horror", "Konami Digital Entertainment");
            videoJuegos[3] = new VideoJuego("Dragon ball Z", 50);
            videoJuegos[4] = new VideoJuego();

            series[0].Entregar();
            series[2].Entregar();
            series[4].Entregar();

            videoJuegos[1].Entregar();
            videoJuegos[3].Entregar();

        }
    }
}