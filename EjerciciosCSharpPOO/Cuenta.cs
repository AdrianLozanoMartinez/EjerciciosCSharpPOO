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
            Titular = titular;
            Cantidad = cantidad;
        }

        public Cuenta(string titular) : this (titular, 0)  //Debemos mandar dato dado en program ("Marina", 1000) o ("Adri") o por defecto (titular, 0)
        {                             //this: Coge el constructor de arriba y da los valores por defecto

        }

        public override string ToString()
        {
            return $"{Titular}: {Cantidad}";
        }

        public void Ingresar(double cantidad)
        {
            if( 0 < cantidad )
            {
                Cantidad += cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            //Opción 1
            Cantidad -= cantidad;

            if ( Cantidad < 0)
            {
                Cantidad = 0;
            }

            //Opción 2
            //Cantidad = Math.Max(0, Cantidad - cantidad); //Es un if, coge el máximo entre 0 y la resta, si da positivo coge ese número, si da negativo coge 0
        }
    }
}
