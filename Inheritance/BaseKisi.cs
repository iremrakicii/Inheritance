namespace Inheritance
{
    public class BaseKisi
    {
        public string FirstName;
        public string LastName;

        public BaseKisi(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public void YazdirAdSoyad()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}");
        }

    }
    public class ogrenci : BaseKisi
    {
        public int StudentNumber;

        public ogrenci(string firstname, string lastname, int studentNumber) : base(firstname, lastname)
        {
            this.StudentNumber = studentNumber;
        }
        public void YazdirOgrenciBilgileri()
        {
            Console.WriteLine("Öğrencimizin bilgileri aşağıdaki gibidir:");
            YazdirAdSoyad();
            Console.WriteLine($"Öğrenci Numarası: {StudentNumber}");
        }

    }
    public class ogretmen : BaseKisi
    {
        public decimal Pay;
        public ogretmen(string firstname, string lastname, decimal pay) : base(firstname, lastname)
        {

            this.Pay = pay;
        }
        public void YazdirOgretmenBilgileri()
        {
            Console.WriteLine("Öğretmenimizin bilgileri aşağıdaki gibidir:");
            YazdirAdSoyad();
            Console.WriteLine($"Maaş bilgisi: {Pay}");
        }
    }
}
