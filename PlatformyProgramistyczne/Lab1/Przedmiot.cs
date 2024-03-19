using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformyProgramistyczne.Lab1
{
    internal class Przedmiot
    {
        public int _wartosc;
        public int _waga;

        public Przedmiot(int wartosc, int waga)
        {
            _wartosc = wartosc;
            _waga = waga;
        }
       
        public double _wartoscDoWagi
        {
            get
            {
                return (double)_wartosc / _waga;
            }
        }

        public override string ToString()
        {
            return "Wartość: " + _wartosc + " Waga: " + _waga;
        }
    }
}
