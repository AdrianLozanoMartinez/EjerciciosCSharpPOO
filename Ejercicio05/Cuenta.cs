using System.Text;
using System.Xml.Linq;

namespace Ejercicio05
{
    class Cuenta
    {
        //Atributos
        private string _headline;
        private double _amount;

        //Propiedades
        public string Headline { get => _headline; set => _headline = value; }
        public double Amount { get => _amount; set => _amount = value; }

        //Constructores
        public Cuenta(string headline, double amount)
        {
            Headline = headline;
            Amount = amount;
        }
        public Cuenta(string headline) : this (headline, 0) {}

        //Métodos
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(); 

            builder.AppendLine($"Titular: {Headline}"); 
            builder.AppendLine($"Cantidad: {Amount}");

            return builder.ToString();
        }

        public void Ingresar(double amount)
        {
            if (amount > 0)
            {
                Amount += amount;
            }
        }

        public virtual void Retirar(double amount)
        {
           Amount -= amount;
        }
    }
}
