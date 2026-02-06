using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdKonsola
{
    internal class Samochod : Pojazd
    {
        private int liczbaDrzwi;

        public Samochod(int liczbaDrzwi, string marka, ushort rokProdukcji) : base(marka, rokProdukcji)
        {
            this.liczbaDrzwi = liczbaDrzwi;
        }

        public Samochod(Samochod auto) : base(auto.marka, auto.rokProdukcji)
        {
            this.liczbaDrzwi = auto.liczbaDrzwi;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            return (100 * dni);
        }

        public override string Opis()
        {
            return base.Opis() + $", Liczba drzwi: {liczbaDrzwi}";
        }
    }
}
