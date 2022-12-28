﻿using System.Globalization;

namespace Ejercicio04
{
    class Electrodomestico
    {
        public enum Colores { blanco, negro, rojo, azul, gris }
        public enum Consumo { A, B, C, D, E, F }

        //Constantes
        private const double PRECIO_BASE = 100;
        private const Colores COLOR = Colores.blanco;
        private const Consumo CONSUMO = Consumo.F;
        private const double PESO = 5;

        //Atributos
        private double _precioBase;
        private Colores _color;
        private Consumo _consumoEnergetico;
        private double _peso;

        //Propiedades
        public double PrecioBase { get => _precioBase; }
        public Colores Color { get => _color; }
        public Consumo ConsumoEnergetico { get => _consumoEnergetico; }
        public double Peso { get => _peso; }

        //Constructores
        public Electrodomestico(double precio, double peso, Colores color, Consumo consumo) 
        { 
            _precioBase = precio;
            ComprobarColor(color);
            ComprobarConsumoEnergetico(consumo);
            _peso = peso;
        }

        public Electrodomestico(double precio, double peso) : this (precio, peso, COLOR, CONSUMO) { }

        public Electrodomestico() : this (PRECIO_BASE, PESO) { }

        //Métodos
        private void ComprobarConsumoEnergetico(Consumo letra)
        {
            if (letra < Consumo.A || letra > Consumo.F) //Si la letra es menor que Consumo.A de valor 0, es decir...números negativos
                                                        //Si la letra es mayor que Consumo.F de valor 5, es decir...números superiores a 5
                                                        //No ponemos igual para excluir los que están dentro del enumerado
                _consumoEnergetico = CONSUMO;
            else
                _consumoEnergetico = letra;
        }

        private void ComprobarColor(Colores color)
        {
            if (color < Colores.blanco || color > Colores.gris) //Si la color es menor que Colores.blanco de valor 0, es decir...números negativos
                                                                //Si la color es mayor que Colores.gris de valor 5, es decir...números superiores a 4
                                                                //No ponemos igual para excluir los que están dentro del enumerado
                _color = COLOR;
            else
                _color = color;
        }

        public void PrecioFinal()
        {
            PrecioFinalConsumo();
            PrecioFinalPeso();
        }

        private void PrecioFinalConsumo()
        {
            switch (ConsumoEnergetico)
            {
                case Consumo.A:
                    _precioBase += 100;
                    break;
                case Consumo.B:
                    _precioBase += 80;
                    break;
                case Consumo.C:
                    _precioBase += 60;
                    break;
                case Consumo.D:
                    _precioBase += 50;
                    break;
                case Consumo.E:
                    _precioBase += 30;
                    break;
                case Consumo.F:
                    _precioBase += 10;
                    break;
            }
        }

        private void PrecioFinalPeso()
        {

        }
    }
}
