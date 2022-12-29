using System.Text;

namespace Ejercicio05
{
    class CuentaJoven : Persona
    {
        //Atributos
        private string _headline;
        private double _amount;
        private int _bonus;

        bool isHeadline = false;

        //Propiedades
        public string Headline { get => _headline; set => _headline = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public int Bonus { get => _bonus; set => _bonus = value; }

        //Constructores
        public CuentaJoven(string headline, double amount, int bonus) 
        { 
            Headline = headline;
            Amount = amount;
            Bonus = bonus;
        }
        public CuentaJoven(string headline) : this (headline, 0, 0) { }

        //Métodos
        public bool EsTitularValido()
        {
            if (Age > 18 && Age < 25)
            {
                isHeadline = true;
            }

            return isHeadline;
        }

        public void Retirar(double amount)
        {
            if (isHeadline == true)
            Amount -= amount;
        }

        public override string ToString()
        {
            StringBuilder builder= new StringBuilder();

            builder.AppendLine("Cuenta Joven");
            builder.AppendLine($"Bonus: {Bonus}");
            builder.AppendLine($"Titular: {Headline}");
            builder.AppendLine($"Cantidad: {Amount}");
            builder.AppendLine($"Nombre: {Name}");
            builder.AppendLine($"Edad: {Age}");
            builder.AppendLine($"Dni: {Dni}");

            return builder.ToString();
        }


    }
}
