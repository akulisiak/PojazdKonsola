using PojazdKonsola;

string marka;
ushort rokProdukcji;
int iloscDrzwi;
bool czyZabytkowy;

List<Pojazd> pojazd =  new List<Pojazd>();
//Samochód
Console.WriteLine("Dodawanie auta \n Podaj markę: ");
marka = Console.ReadLine();
Console.WriteLine("Podaj rok produkcji: ");
rokProdukcji = ushort.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość drzwi: ");
iloscDrzwi = int.Parse(Console.ReadLine());

pojazd.Add(new Samochod(iloscDrzwi, marka, rokProdukcji));

//Motocykl
Console.WriteLine("Dodawanie motocykla \n Podaj markę: ");
marka = Console.ReadLine();
Console.WriteLine("Podaj rok produkcji: ");
rokProdukcji = ushort.Parse(Console.ReadLine());
Console.WriteLine("Czy motocykl jest zabytkowy? ");
czyZabytkowy = bool.Parse(Console.ReadLine());

pojazd.Add(new Motocykl(czyZabytkowy, marka, rokProdukcji));

foreach (var p in pojazd)
{
    Console.WriteLine($"Opis: {p.Opis()}");
    Console.WriteLine($"Koszt wynajmu na 5 dni wynosi: {p.ObliczKosztWynajmu(5)}");
}