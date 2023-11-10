////Soru-7 V1.1 İlk 10 mükemmel sayıyı bulan bir C# programı yazın.

////Mükemmel Sayı => Kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayıya Mükemmel sayı denir.
//// Örnek; 6-- > 1,2,3 =>   1 + 2 + 3 = 6

//Console.WriteLine();
//Console.WriteLine(">>> Bu Program İlk 10 Mükemmel Sayıyı Listeler <<<");
//Console.WriteLine("**************************************************");
//Console.WriteLine();

//decimal sayac = 0;
//for (decimal sayi = 2; sayac < 4; sayi++)
//{
//    decimal toplam = 0;
//    for (decimal i = 1; i <= sayi / 2; i++)
//    {
//        if (sayi % i == 0)
//        {
//            toplam += i;
//        }
//    }
//    if (toplam == sayi)
//    {
//        sayac++;
//        Console.WriteLine($"{sayac}.Mükemmel Sayı {sayi} sayısıdır.");
//        Console.WriteLine();       
//    } 
//}
//Console.WriteLine("*** FINISHED ***");
//Console.ReadLine();
//// ilk 10 mükemmel sayı çok uzun süreceğinden ilk 4 mükemmel sayı hesaplamak daha mantıklı.
//============================================================================================//

////Soru-7 V1.2 İlk 10 mükemmel sayıyı bulan bir C# programı yazın.
using System.Numerics;

BigInteger sayac = 0;
for (BigInteger sayi = 2; sayac < 10; sayi++)
{
    BigInteger adet = 0;
    BigInteger kuvvet1 = (BigInteger)(Math.Pow(2, (double)sayi) - 1);
    for (BigInteger i = 1; i <= kuvvet1; i++)
    {
        if (kuvvet1 % i == 0)
        {
            adet++;
        }
    }
    if (adet == 2)
    {
        Console.WriteLine($"=> ASAL {kuvvet1}");
        Console.WriteLine($"Mükemmel => {((BigInteger)Math.Pow(2, (double)sayi) - 1) * ((BigInteger)Math.Pow(2, (double)(sayi - 1)))}");
        Console.WriteLine("=======");
        sayac++;
    }
}
//============================================================================================//

////Soru-7 V1.3 İlk 10 mükemmel sayıyı bulan bir C# programı yazın.
//using System.Numerics;
//MersenneAsallariYontemi();
//static void MersenneAsallariYontemi()
//{
//    for (BigInteger sayi = 2; ; sayi++)
//    {
//        if (AsalKontrol(sayi))
//        {
//            BigInteger result = (BigInteger)Math.Pow(2, (double)sayi);
//            if (AsalKontrol(result - 1))
//            {
//                BigInteger mukemmelSayi = ((BigInteger)Math.Pow(2, (double)(sayi - 1)) * (result - 1));
//                Console.WriteLine("Mersenne Asalları Yöntemi :" + mukemmelSayi);
//            }
//        }
//    }
//}
//static bool AsalKontrol(BigInteger sayi)
//{
//    bool kontrol = true;
//    for (BigInteger i = 2; i <= sayi / 2; i++)
//    {
//        if (sayi % i == 0)
//        {
//            kontrol = false;
//            break;
//        }
//    }
//    return kontrol;
//}
Console.ReadLine();