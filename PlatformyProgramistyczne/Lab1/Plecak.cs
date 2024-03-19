using System.Runtime.InteropServices;

namespace PlatformyProgramistyczne.Lab1
{
    internal class Plecak
    {
        private int _liczbaPrzedmiotow;
        private Przedmiot[] _przedmioty;

        public Plecak(int n, int seed)
        {
            _liczbaPrzedmiotow = n;
            Random random = new Random(seed);
            _przedmioty = new Przedmiot[n];
            for (int i = 0; i < n; i++)
            {
                _przedmioty[i] = new Przedmiot(random.Next(1, 10), random.Next(1, 10));
            }
        }

        public Result Solve(int capacity)
        {
            Array.Sort(_przedmioty, (x, y) => y._wartoscDoWagi.CompareTo(x._wartoscDoWagi));


            //put the items in the bag
            int currentWeight = 0;
            int currentValue = 0;
            int numberOfItems = 0;
            int[] map_items = new int[_liczbaPrzedmiotow];
            for (int i = 0; i < _liczbaPrzedmiotow; i++)
            {
                if (currentWeight + _przedmioty[i]._waga <= capacity)
                {
                    map_items[i] = 1;
                    currentWeight += _przedmioty[i]._waga;
                    currentValue += _przedmioty[i]._wartosc;
                    numberOfItems++;
                }
                else
                {
                    map_items[i] = 0;
                }
            }

            int[] items = new int[numberOfItems];
            int j = 0;
            for (int i = 0; i < _liczbaPrzedmiotow; i++)
            {
                if (map_items[i] == 1)
                {
                    items[j] = i;
                    j++;
                }
            }

            Result result = new Result(items, currentValue, currentWeight);
            return result;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < _liczbaPrzedmiotow; i++)
            {
                result += $"Item {i}: {_przedmioty[i]}\n";
            }
            return result;
        }
    }

}
