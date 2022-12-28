namespace Ejercicio04
{
    class Program
    {
        const int POSICION = 10;

        static void Main()
        {
            double sumaLavadora = 0;
            double sumaTelevision = 0;
            double sumaElectrodomesticos = 0;

            Electrodomestico[] consumo = new Electrodomestico[POSICION];

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

            consumo = new Electrodomestico[POSICION] { 

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
            new Electrodomestico(120, "azul", 'C', 25),
            new Electrodomestico(115, 15),
            new Electrodomestico(),
            new Lavadora(200, "Gris", 'a', 10),
            new Lavadora(250, 50),
            new Lavadora(),
            new Television(1200.95, "Blanco", 'c', 3, 37, true),
            new Television(320, "ROJO", 'A', 2, 55, false),
            new Television(650, 1.5),
            new Television()
            };


            foreach (Electrodomestico local in consumo)
            {
            }

        }
    }
}