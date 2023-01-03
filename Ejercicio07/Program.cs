namespace Ejercicio07
{
    class Program
    {
        static void Main()
        {
            //Instancias
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

            //Entrega
            series[0].Entregar();
            series[2].Entregar();
            series[4].Entregar();

            videoJuegos[1].Entregar();
            videoJuegos[3].Entregar();

            //Contar entregados
            int ContadorSerie = 0;
            int ContadorJuego = 0;
            int Contador = 0;

            foreach (Serie serie in series)
            {
                if (serie.EsEntregado())
                {
                    ContadorSerie++;
                    Contador++;
                }
            }
            Console.WriteLine($"Series entregadas: {ContadorSerie}");

            foreach (VideoJuego juego in videoJuegos)
            {
                if (juego.EsEntregado())
                {
                    ContadorJuego++;
                    Contador++;
                }
            }
            Console.WriteLine($"Juegos entregados: {ContadorJuego}");


            Console.WriteLine($"Total entregados: {Contador}");

            Console.WriteLine();

            //Creamos una istancia con la 1º posición
            Serie serieMayor = series[0];
            VideoJuego juegoMayor = videoJuegos[0];

            for (int i = 1; i < series.Length; i++)
            {
                /* 1:  La serie[i] es mayor que la serieMayor
                 * 0:  Las Series son iguales
                 * -1: La serie[i] es menor que la serieMayor*/

                //Si lo que ya estaba serie[i] o Number es mayor que lo que metemos en parámetro serieMayor o serie.Number
                if (series[i].CompareTo(serieMayor) == 1)
                {
                    serieMayor = series[i];
                }
                if (videoJuegos[i].CompareTo(juegoMayor) == 1)
                {
                    juegoMayor = videoJuegos[i];
                }
            }

            

            //Mostrar
            for (int i = 0; i < series.Length; i++)
            {
                Console.WriteLine(series[i]);
            }

            for (int i = 0; i < videoJuegos.Length; i++)
            {
                Console.WriteLine(videoJuegos[i]);
            }

            Console.WriteLine();

            Console.WriteLine($"<<<<<<<<<<<<<<<<<<<<<Serie mayor>>>>>>>>>>>>>>>>>>>>:\n {serieMayor}");
            Console.WriteLine($"<<<<<<<<<<<<<<<<<<<<<Juego mayor>>>>>>>>>>>>>>>>>>>>:\n {juegoMayor}");
        }
    }
}