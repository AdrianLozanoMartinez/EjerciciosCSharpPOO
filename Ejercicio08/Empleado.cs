using System.Text;

namespace Ejercicio08
{
    class Empleado
    {
        //Constante
        private const int PLUS = 300;

        //Atributos
        protected string _nombre;
        protected int _edad;
        protected double _salario;

        ////Propiedades
        //public string Nombre { get => _nombre; set => _nombre = value; }
        //public int Edad { get => _edad; set => _edad = value; }
        //public double Salario { get => _salario; set => _salario = value; }

        //Constructores
        protected Empleado() { }

        ////Métodos
        //public override string ToString()
        //{
        //    StringBuilder builder = new StringBuilder();
        //        builder.AppendLine($"Nombre: {Nombre}");
        //        builder.AppendLine($"Edad: {Edad}");
        //        builder.AppendLine($"Salario: {Salario}");

        //    return builder.ToString();
        //}
    }
}
