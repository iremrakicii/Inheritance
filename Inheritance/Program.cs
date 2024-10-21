using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Ogretmen ogretmena = new Ogretmen("Ayşe", "Öztürk", 30000);
        ogretmena.YazdirOgretmenBilgileri();

        Console.WriteLine("-------------------------------------------------------");

        Ogrenci ogrenci = new Ogrenci("İrem", "Rakıcı", 227);
        ogrenci.YazdirOgrenciBilgileri();

    }
}

