using static Ejercicio04.Electrodomestico;

namespace Ejercicio04
{
    class Program
    {
        const int POSICION = 10;

        static void Main()
        {
            double precioElectrodomesticos = 0;
            double precioLavadora = 0;
            double precioTelevision = 0;

            Electrodomestico[] electrodomesticos = new Electrodomestico[POSICION];

            //////////////////////////////////////////////////////////////POR TECLADO/////////////////////////////////////////////////////////////

            /* for (int i = 0; i < consumo.Length; i++)
             {
 /////////ELECTRODOMÉSTICOS////////////
                 Console.WriteLine("Introduce letra");
                 try
                 {
                     letra = (Electrodomestico.CoonsumoEnergetico)Enum.Parse(typeof(Electrodomestico.CoonsumoEnergetico), Console.ReadLine(), true);
                     precio = (double)letra;
                     //Console.WriteLine(precio);
                 }
                 catch (Exception e)
                 {
                     error = e.Message;
                 }
                 //Color
                 color = Electrodomestico.COLOR;
                 Console.WriteLine("Introduce color");
                 try
                 {
                     color = (Electrodomestico.Coolor)Enum.Parse(typeof(Electrodomestico.Coolor), Console.ReadLine(), true);
                 }
                 catch (Exception e)
                 {
                     error = e.Message;
                 }
                 Console.WriteLine("Introduce peso");
                 peso = double.Parse(Console.ReadLine());
 /////////TELEVISION////////////
                 //resolucion
                 Console.WriteLine("Introduce resolución (pulgadas)");
                 resolucion = double.Parse(Console.ReadLine());
                 //tdt
                 Console.WriteLine("Introduce true/false si tiene TDT");
                 tdt = bool.Parse(Console.ReadLine());
             }*/

            //////////////////////////////////////////////////////////////MOSTRAR/////////////////////////////////////////////////////////////

            electrodomesticos = new Electrodomestico[POSICION] { 

            //MODO TECLADO
            /*new Lavadora(precio, color, letra, peso), 
            new Lavadora(precio, color, letra, peso), 
            new Lavadora(precio, color, letra, peso), 
            new Lavadora(precio, color, letra, peso), 
            new Lavadora(precio, color, letra, peso),
            new Television(precio, color, letra, peso, resolucion, tdt), 
            new Television(precio, color, letra, peso, resolucion, tdt), 
            new Television(precio, color, letra, peso, resolucion, tdt), 
            new Television(precio, color, letra, peso, resolucion, tdt), 
            new Television(precio, color, letra, peso, resolucion, tdt)*/

            //MODO MANUAL
            new Electrodomestico(120, 25, Electrodomestico.Colores.blanco, Electrodomestico.Consumo.E),
            new Electrodomestico(115, 15),
            new Electrodomestico(),
            new Lavadora(30, 200, 10, Electrodomestico.Colores.gris, Electrodomestico.Consumo.A),
            new Lavadora(250, 50),
            new Lavadora(),
            new Television(1080, true, 1200.95, 3, Electrodomestico.Colores.rojo, Electrodomestico.Consumo.C),
            new Television(720, false, 582, 5, Electrodomestico.Colores.azul, Electrodomestico.Consumo.B),
            new Television(650, 1.5),
            new Television()
            };


            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                electrodomestico.PrecioFinal();

                precioElectrodomesticos += electrodomestico.PrecioBase;

                if (electrodomestico is Lavadora)
                    precioLavadora += electrodomestico.PrecioBase;
                else if (electrodomestico is Television)
                    precioTelevision += electrodomestico.PrecioBase;
            }
            Console.WriteLine($"Precio total electrodomésticos: {precioElectrodomesticos}");
            Console.WriteLine($"Precio total lavadoras: {precioLavadora}");
            Console.WriteLine($"Precio total Televisión: {precioTelevision}");
        }
    }
}