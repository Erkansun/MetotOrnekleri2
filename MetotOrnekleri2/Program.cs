namespace MetotOrnekleri2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"1. sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Metotlar metotTopla = new Metotlar(); // Metotlar sınıfının içerisindeki Topla() metutunu static olarak tanımlamadığımız için nesneyi new ile örneklemek gerekiyor.

            //int sonuc = metotTopla.Topla(s1: sayi1, s2: sayi2);

            Console.WriteLine($"2 sayının toplamı: {metotTopla.Topla(s1: sayi1, s2: sayi2)}");

            Console.ReadKey();
        }

        class Metotlar()
        {
            public int Topla(int s1, int s2)
            {
                return s1 + s2;
            }
        }
    }
}
