using PojazdKonsola;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestObliczaniaKosztuWynajmuSamochodu()
        {
            //Arrange
            Samochod samochod = new Samochod(5, "xyz", 1900);
            double wartoscOczekiwana = 500;
            int iloscDni = 5;
            //Act
            double wynik = samochod.ObliczKosztWynajmu(iloscDni);   
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }

        [TestMethod]
        public void TestObliczaniaKosztuWynajmuNieZabytkowegoMotocykla()
        {
            //Arrange
            Motocykl motocykl = new Motocykl(false, "xyz", 1900);
            double wartoscOczekiwana = 350;
            int iloscDni = 5;
            //Act
            double wynik = motocykl.ObliczKosztWynajmu(iloscDni);
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }

        [TestMethod]
        public void TestObliczaniaKosztuWynajmuZabytkowegoMotocyklu()
        {
            //Arrange
            Motocykl motocykl = new Motocykl(true, "xyz", 1900);
            double wartoscOczekiwana = 420;
            int iloscDni = 5;
            //Act
            double wynik = motocykl.ObliczKosztWynajmu(iloscDni);
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }
    }
}