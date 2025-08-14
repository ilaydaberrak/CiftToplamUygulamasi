using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kaç tane sayı çifti giriceksiniz?");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[,] sayilar = new int[n, 2]; //n satır, her satırda 2 sayı
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i + 1}. çiftin 1.sayısını girin:");
            sayilar[i, 0] = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"{i + 1}. çiftin 2.sayısını girin:");
            sayilar[i, 1] = int.Parse(Console.ReadLine() ?? "0");
        }
        Console.WriteLine("\nSonuçlar:");
        for (int i = 0; i < n; i++)
        {
            int toplam = sayilar[i, 0] + sayilar[i, 1];
            if (sayilar[i, 0] == sayilar[i, 1])
            {
                Console.WriteLine(Math.Pow(toplam, 2));
            }
            else
            {
                Console.WriteLine(toplam);
            }
        }
    }
}
