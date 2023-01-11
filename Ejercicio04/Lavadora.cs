namespace Ejercicio04
{
    class Lavadora : Electrodomestico
    {
        //Constantes
        private const int CARGA = 5;

        //Atributos
        private double _carga;

        //Propiedades
        public double Carga { get => _carga; }

        //Constructores
        public Lavadora(double carga, double precio, double peso, Colores color, Consumo consumo) : base(precio, peso, color, consumo)
        {
            _carga = carga;
        }
        public Lavadora(double precio, double peso) : this(CARGA, precio, peso, COLOR, CONSUMO) { }
        public Lavadora() : this(PRECIO_BASE, PESO) { }

        public override void PrecioFinal()
        {
            base.PrecioFinal();

            if (_carga > 30) _precioBase += 50;
        }
    }
}
