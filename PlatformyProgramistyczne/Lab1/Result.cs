using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatformyProgramistyczne.Lab1
{
    internal class Result
    {
        public int[] _przedmioty;
        public int _wartosc;
        public int _waga;

        public Result(int[] przedmioty, int wartosc, int waga)
        {
            _przedmioty = przedmioty;
            _wartosc = wartosc;
            _waga = waga;
        }

        public override string ToString()
        {
            string sth = "";
            for 
                (int i = 0; i < _przedmioty.Length; i++)
            {
                sth += _przedmioty[i] + " ";
            }
            return "Wartość: " + _wartosc + " Waga: " + _waga + "\n" + sth;
        }
    }
}
