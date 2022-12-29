namespace Ejercicio05
{
    class CuentaJoven : Persona
    {
        //Atributos
        private string _headline;
        private double _amount;
        private int _bonus;

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
        public void EsTitularValido()
        {
            bool isHeadline = false;

            if (Age > 18 && Age < 25)
            {
                isHeadline = true;
            }
        }
    }
}
