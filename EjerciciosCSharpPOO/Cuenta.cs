namespace Ejercicio01
{
    class Cuenta
    {
        //Atributo
        private string _titular;
        private double _cantidad;

        //Propiedad
        public string Titular { get => _titular; set => _titular = value; }
        public double Cantidad { get => _cantidad; set => _cantidad = value; }

        //Constructor
        public Cuenta(string titular, double cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }

        public Cuenta(string titular) : this (titular, 0)  //Debemos mandar dato dado en program o por defecto
        {

        }

        public void ToString()
        {
            Console.WriteLine($"{Titular}: {Cantidad}");
        }

        public void Ingresar(double cantidad)
        {
            if(0 > cantidad)
            {
                Cantidad += cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            Cantidad -= cantidad;

            if ( 0 < Cantidad)
            {
                Cantidad = 0;
            }
        }
    }
}
