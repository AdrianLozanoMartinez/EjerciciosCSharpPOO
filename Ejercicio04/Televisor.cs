using static Ejercicio04.Electrodomestico;
using System.Drawing;

namespace Ejercicio04
{
    class Television : Electrodomestico
    {
        //Constantes
        private const int RESOLUCION = 20;
        private const bool TDT = false;

        //Atributos
        private int _resolucion;
        private bool _tdt;

        //Propiedades
        public int Resolucion { get => _resolucion; }
        public bool Tdt { get => _tdt; }

        //Constructores
        public Television(int resolucion, bool tdt, double precio, double peso, Colores color, Consumo consumo) : base (precio, peso, color, consumo) 
        { 
            _resolucion = resolucion;
            _tdt = tdt;
        }
        public Television(double precio, double peso) : this(RESOLUCION, TDT, precio, peso, COLOR, CONSUMO) { }
        public Television() : this(PRECIO_BASE, PESO) { }

        public override void PrecioFinal()
        {
            base.PrecioFinal();

            if (_tdt) PrecioBase += 50;
            if (_resolucion > 40) PrecioBase *= 1.3;
            /* Es igual que si hacemos:
               Precio * 100     Precio * 30            ( 100   30  )   
               ------------  +  ----------- = Precio * ( --- + --- ) = 1 + 0.3 = 1.3
                   100              100                ( 100   100 ) 
             */
        }
    }
}
