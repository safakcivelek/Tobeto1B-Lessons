//Soru-2   Fibonacci serisindeki ilk 100 sayıyı yazdıracak bir C# fonksiyonu yazın

// Fibonacci => 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987..diye devam eden her sayının kendisinden önceki iki ardışık sayının toplamına eşit olduğu sayı dizisine Fibonacci dizisi denmektedir.

using System.Numerics;

int girdi = 100;
BigInteger Fibonacci = 0;
BigInteger sayi1 = 1;
BigInteger sayi2 = 1;
Console.WriteLine($"*** İlk {girdi} Adet Fibonacci Sayısı Listeleniyor ***");
Console.WriteLine("=======================================================");
for (int i = 0; i < girdi; i++)
{
    Fibonacci = sayi1 + sayi2;
    sayi1 = sayi2;
    sayi2 = Fibonacci;
    Console.WriteLine($"{i + 1}.Fibo Sayısı => {Fibonacci}");
}
Console.WriteLine();
Console.WriteLine("*** FINISHED ***");
Console.ReadKey();