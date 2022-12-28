using System;

namespace Ejercicio03
{
    class Password
    {
        //Constantes
        private const int LENGTH = 8;
        private const string CODE = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyxz0123456789";

        //Atributos
        private int _length;
        private string _password;

        //Propiedades
        public int Length { get => _length; set => _length = value; }
        public string PasswordProperty { get => _password; }

        //Constructores
        public Password(int length) 
        {
            Length = length;
            _password = GenerarPassword();
        }
        public Password() : this (LENGTH) { }

        public string GenerarPassword()
        {
            Random random = new Random();

            //Otra forma añade este paso
            //char[] contrasena = new char[_length];

            string caracteres = "";

            //Otra forma
            //for (int i = 0; i < caracteres.Length; i++)
            for (int i = 0; i < _length; i++)
            {
                //Otra forma
                //contrasena[i] = CODE[random.Next(CODE.Length)];
                caracteres += CODE[random.Next(CODE.Length)];
            }

            //Otra forma
            //caracteres = new string(contrasena);
            return caracteres;
        }

        public bool EsFuerte()
        {
            bool strong = false;
            int digit = 0;
            int lower = 0;
            int upper = 0;

            for (int i = 0; i < _password.Length; i++)
            {
                if (char.IsDigit(_password[i]))
                {
                    digit++;
                }
                else if (char.IsLower(_password[i]))
                {
                    lower++;
                }
                else if (char.IsUpper(_password[i]))
                {
                    upper++;
                }
            }

            if (upper > 2 && lower > 1 && digit > 5)
            {
                strong = true;
            }

            return strong;
        }
    }
}
