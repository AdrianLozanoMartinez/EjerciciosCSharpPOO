using System.Text;

namespace Ejercicio08
{
    class Comercial : Empleado
    {
        //Atributos
        private double _comision;

        //Propiedades
        public double Comision { get => _comision; set => _comision = value; }
        /*public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public double Salario { get => _salario; set => _salario = value; }*/

        //Constructores
        public Comercial(double comision, string nombre, int edad, double salario)
        {
            Comision = comision;
            /*Nombre = nombre;
            Edad = edad;
            Salario = salario;*/
            _nombre = nombre;
            _edad = edad;
            _salario = salario;
        }

        //Métodos
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            /*builder.AppendLine($"Nombre: {Nombre}");
            builder.AppendLine($"Edad: {Edad}");
            builder.AppendLine($"Salario: {Salario}");*/
            builder.AppendLine($"Nombre: {_nombre}");
            builder.AppendLine($"Edad: {_edad}");
            builder.AppendLine($"Salario: {_salario}");
            builder.AppendLine($"Comisión: {Comision}");
            builder.AppendLine($"Plus?: {AplicarPlus()}");

            return builder.ToString();
        }

        public bool AplicarPlus()
        {
            bool plus = false;

            if (_edad > 30 && Comision > 200)
            {
                plus = true;
            }
            return plus;
        }
    }
}
