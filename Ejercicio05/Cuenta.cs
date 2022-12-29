using System.Text;
using System.Xml.Linq;

namespace Ejercicio05
{
    class Cuenta
    {
        //Atributos
        private string _titular;
        private double _cantidad;

        //Propiedades
        public string Titular { get => _titular; set => _titular = value; }
        public double Cantidad { get => _cantidad; set => _cantidad = value; }

        //Constructores
        public Cuenta(string titular, double cantidad)
        {
            Titular = titular;
            Cantidad = cantidad;
        }
        public Cuenta(string titular) : this (titular, 0) {}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(); 

            builder.AppendLine($"Titular: {Titular}"); 
            builder.AppendLine($"Cantidad: {Cantidad}");

            return builder.ToString();
        }
    }
}
