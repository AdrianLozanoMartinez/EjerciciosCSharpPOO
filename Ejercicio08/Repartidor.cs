using System.Text;

namespace Ejercicio08
{
    class Repartidor : Empleado
    {
        //Atributos
        private string _zona;

        //Propiedades
        public string Zona { get => _zona; set => _zona = value; }
        /*public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public double Salario { get => _salario; set => _salario = value; }*/

        //Constructores
        public Repartidor(string zona, string nombre, int edad, double salario)
        {
            Zona = zona;
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
            builder.AppendLine($"Zona: {Zona}");
            builder.AppendLine($"Plus?: {AplicarPlus()}");

            return builder.ToString();
        }

        public bool AplicarPlus()
        {
            bool plus = false;

            if ( _edad < 25 && Zona == "zona 3" )
            {
                plus = true;
            }
            return plus;
        }
    }
}
