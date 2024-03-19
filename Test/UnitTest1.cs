using PlatformyProgramistyczne.Lab1;
using System.Xml.Linq;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodCountElements()
        {
            Plecak plecak = new Plecak(10, 1);
            Result result = plecak.Solve(10);
            Assert.IsTrue(result._przedmioty.Length > 0);
        }

        //Sprawdzenie, czy je�li �aden przedmiot nie spe�nia ogranicze�, to zwr�cono puste rozwi�zanie.
        [TestMethod]
        public void TestMethodNoElements()
        {
            Plecak plecak = new Plecak(0, 1);
            Result result = plecak.Solve(10);
            Assert.IsTrue(result._przedmioty.Length == 0);
        }

        //Sprawdzenie, czy kolejno�� przedmiot�w ma wp�ywa na znalezione rozwi�zanie.
        [TestMethod]
        public void TestMethodOrder()
        {
            Plecak plecak = new Plecak(10, 1);
            Result result = plecak.Solve(10);
            int[] items = result._przedmioty;
            int[] items2 = result._przedmioty;
            Array.Reverse(items2);
            Assert.IsFalse(items.SequenceEqual(items2));
        }

        //Sprawdzenie, czy zwr�cone rozwi�zanie jest poprawne.
        [TestMethod]
        public void TestMethodCorrectness()
        {
            Plecak plecak = new Plecak(3, 1);
            Result result = plecak.Solve(10);
            Assert.IsTrue(result._wartosc == 9);
        }

        //Sprawdzanie czy seed ma wp�yw na wynik.
        [TestMethod]
        public void TestMethodSeed()
        {
            Plecak plecak = new Plecak(10, 1);
            Result result = plecak.Solve(10);
            Plecak plecak2 = new Plecak(10, 2);
            Result result2 = plecak2.Solve(10);
            Assert.IsFalse(result._przedmioty.SequenceEqual(result2._przedmioty));
        }


    }
}