/*  Armstrong Sayı:
 *  Bir sayının her rakamının ayrı ayrı o sayının basamak değeri kadar kuvveti alındıktan sonra, kuvveti alınmış her rakam toplanır.
 *  Eğer bu toplam  sayının kendisine eşit ise bu sayıya "Armstrong sayısı" denir.
 *  Örnek; 153 için =>  1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 ... 
 */

////Soru-1 V1.1  Girilen sayının Armstrong sayısı olup olmadığını kontrol eden bir C# programı yazınız.
ArmstrongNumber1();

//Soru-1 V1.2  Girilen sayının Armstrong sayısı olup olmadığını kontrol eden bir C# programı yazınız.
//ArmstrongNumber2();

Console.ReadKey();

static void ArmstrongNumber1()
{
    Console.WriteLine("Lütfen bir sayı giriniz");
    string charDizi = Console.ReadLine();

    // Çevrilen tamsayıların depolanacağı diz
    int[] intDizi = new int[charDizi.Length];
    int toplam = 0;

    for (int i = 0; i < charDizi.Length; i++)
    {
        // Her karakteri tamsayıya çevir ve diziye ekle
        intDizi[i] = int.Parse(charDizi[i].ToString());

        int sonuc = 1;
        // kuvvet alır
        for (int j = 0; j < intDizi.Length; j++)
        {
            sonuc *= intDizi[i];
        }
        toplam += sonuc;
    }
    if (toplam == int.Parse(charDizi))
        Console.WriteLine($"{charDizi} sayısı Armstrong sayıdır.");
    else
        Console.WriteLine($"{charDizi} sayısı Armstrong sayı DEĞİLDİR!");
}
static void ArmstrongNumber2()
{
    Console.WriteLine("Bir sayı giriniz");
    int girdi = int.Parse(Console.ReadLine());

    int sayi = girdi;
    int basamakDegeri = 0;
    int toplam = 0;
    while (sayi > 0)
    {
        basamakDegeri = sayi % 10;
        sayi = sayi / 10;

        int kuvvet = 1;
        for (int i = 0; i < BasamakSayisi(girdi); i++)
        {
            kuvvet = kuvvet * basamakDegeri;
        }
        toplam += kuvvet;
    }
    if (toplam == girdi)
        Console.WriteLine($"{girdi} sayısı Armstrong sayıdır.");
    else
        Console.WriteLine($"{girdi} sayısı Armstrong sayı DEĞİLDİR!");
}
// Basamak sayısı 
static int BasamakSayisi(int girdi)
{
    int sayac = 0;
    while (girdi > 0)
    {
        girdi /= 10;
        sayac++;
    }
    return sayac;
}
// ÖNEMLİ NOT!! => char türü int' türe çevrilemez. Böyle bir duruma ihtiyaç varsa char tür string'e çevilir daha sonra string tür int'e çevrilebilir.

