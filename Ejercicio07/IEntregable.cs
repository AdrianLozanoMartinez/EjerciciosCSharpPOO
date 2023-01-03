namespace Ejercicio07
{
    interface IEntregable
    {
        public bool Entregar();

        public bool Devolver();

        public bool EsEntregado();

        public int CompareTo(object a);
    }
}
