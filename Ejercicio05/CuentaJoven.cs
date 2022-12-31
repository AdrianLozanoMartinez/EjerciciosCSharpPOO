using System.Text;

namespace Ejercicio05
{
    class CuentaJoven : Cuenta
    {
        //Atributos
        private string _headline;
        private double _amount;
        private int _bonus;

        bool _isHeadline = false;

        //Propiedades
        public string Headline { get => _headline; set => _headline = value; }
        public double Amount { get => _amount; set => _amount = value; }
        public int Bonus { get => _bonus; set => _bonus = value; }
        public bool IsHeadline { get => _isHeadline; set => _isHeadline = value; }

        //Constructores
        public CuentaJoven(string headline, double amount, int bonus) : base (headline, amount)
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
                _isHeadline = true;
            }

            return _isHeadline;
        }

        public override void Retirar(double amount)
        {
            EsTitularValido();

            if (_isHeadline == true)
            Amount -= amount;
        }

        public override void Ingresar(double amount)
        {
            base.Ingresar(amount);

           if (amount > 0)
            {
                Amount += amount;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Cuenta Joven");

            base.ToString();

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
