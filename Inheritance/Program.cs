using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        ogretmen ogretmena = new ogretmen("Ayşe", "Öztürk", 30000);
        ogretmena.YazdirOgretmenBilgileri();

        Console.WriteLine("-------------------------------------------------------");

        ogrenci ogrenci = new ogrenci("İrem", "Rakıcı", 227);
        ogrenci.YazdirOgrenciBilgileri();

    }
}

