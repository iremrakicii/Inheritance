using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Ogretmen ogretmena = new ogretmen("Ayşe", "Öztürk", 30000);
        ogretmena.YazdirOgretmenBilgileri();

        Console.WriteLine("-------------------------------------------------------");

        Ogrenci ogrenci = new ogrenci("İrem", "Rakıcı", 227);
        ogrenci.YazdirOgrenciBilgileri();

    }
}

