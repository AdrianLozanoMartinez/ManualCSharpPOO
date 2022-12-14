﻿using System.Drawing;
using System;

namespace xEjercicio4
{
    class Electrodomestico
    {
        //Enumerados
        /*public enum CoonsumoEnergetico { A = 100, B = 80, C = 60, D = 50, E = 30, F = 10 }
        public enum Coolor { blanco, negro, rojo, azul, gris }*/

        //Atributos
        private double _precioBase;
        private double _peso;
        private string _color;
        private char _consumoEnergetico;
        //private Coolor _color;
        //private CoonsumoEnergetico _consumoEnergetico;

        //Constantes
        public const double PRECIOBASE = 100;//€
        public static readonly string COLOR = "blanco"; // blanco, negro, rojo, azul y gris
        public static readonly char CONSUMOENERGETICO = 'F'; // blanco, negro, rojo, azul y gris
        public const double PESO = 5;//kg
        //public const Coolor COLOR = Coolor.blanco; // blanco, negro, rojo, azul y gris
        //public const CoonsumoEnergetico CONSUMOENERGETICO = CoonsumoEnergetico.F;

        //Propiedades
        public double PrecioBase { get => _precioBase; }
        public string Color { get => _color; }
        public char ConsumoEnergetico { get => _consumoEnergetico; }
        public double Peso { get => _peso; }
        //public Coolor Color { get => _color; }
        //public CoonsumoEnergetico ConsumoEnergetico { get => _consumoEnergetico; }

        //Constructores
        //public Electrodomestico(double precioBase, Coolor color, CoonsumoEnergetico consumoEnergetico, double peso) 
        public Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso) 
        {
            _precioBase = PrecioFinal(precioBase, peso);
            _color = ComprobarColor(color);
            _consumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            _peso = peso;
        }
        public Electrodomestico(double precioBase, double peso) : this(precioBase, COLOR, CONSUMOENERGETICO, peso) { } //color y consumoEnergetico lo ponemos de la constante

        public Electrodomestico() : this(PRECIOBASE, PESO) { } //precio y peso lo ponemos de la constante

        //Métodos
        //private CoonsumoEnergetico ComprobarColor(CoonsumoEnergetico letra)
        private char ComprobarConsumoEnergetico(char letra) //(letras entre A y F)
        {
            /*if (letra != CoonsumoEnergetico.A || letra != CoonsumoEnergetico.B || letra != CoonsumoEnergetico.C || letra != CoonsumoEnergetico.D || letra != CoonsumoEnergetico.E)
            {
                letra = CONSUMOENERGETICO;
            }*/
           
            double plus = 0;
            switch (Char.ToUpper(letra))
            {
                case 'A':
                    plus += 100;
                    break;
                case 'B':
                    plus += 80;
                    break;
                case 'C':
                    plus += 60;
                    break;
                case 'D':
                    plus += 50;
                    break;
                case 'E':
                    plus += 30;
                    break;
                default:
                    plus += 10;
                    break;
            }


            return Char.ToUpper(letra);
        }

        //private Coolor ComprobarColor(Coolor colorEntrado)
        private string ComprobarColor(string colorEntrado)
        {
            /*if (colorEntrado != Coolor.azul || colorEntrado != Coolor.blanco || colorEntrado != Coolor.rojo || colorEntrado != Coolor.negro || colorEntrado != Coolor.gris)
            {
                colorEntrado = COLOR;
            }*/

        string[] CoLor = { "blanco", "negro", "rojo", "azul", "gris" };
 
        bool encontrado = false;

            for (int i = 0; i < CoLor.Length && !encontrado; i++)
            {

                if (CoLor[i] == colorEntrado.ToLower())
                {
                    encontrado = true;
                }

            }

            if (encontrado)
            {
                colorEntrado = colorEntrado.ToLower();
            }
            else
            {
                colorEntrado = COLOR;
            }

            return colorEntrado;
        }

        public virtual double PrecioFinal(double precioEntrado, double pesoEntrado)
        {
            double precio = 0;
            double peso = 0;

            if (pesoEntrado >= 0 && pesoEntrado <= 19)
            {
                peso = 10;
            }
            else if (pesoEntrado >= 20 && pesoEntrado <= 49)
            {
                peso = 50;
            }
            else if (pesoEntrado >= 50 && pesoEntrado <= 79)
            {
                peso = 80;
            }
            else if (pesoEntrado >= 80)
            {
                peso = 100;
            }

            precio = precioEntrado + peso;

            return precio;
        }

        public override string ToString()
        {
            return "Electrodoméstico: ";
        }
    }
}
