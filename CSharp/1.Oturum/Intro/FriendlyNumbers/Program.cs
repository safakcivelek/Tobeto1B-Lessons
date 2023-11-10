// Soru-2  Parametre olarak girilen iki sayının arkadaş sayılar olup olmadığını bulan programı yazınız.
/*
 * Arkadaş Sayılar : İki sayının kendileri hariç pozitif bölenleri toplamı birbirlerine eşitse bu sayılar arkadaş sayı olarak adlandırılır. 
 * Örneğin 220 ve 284 sayıları bir çift arkadaş sayıdır.
 * 220 kendisi hariç pozitif bölenler toplamı => 1+2+4+5+10+11+20+22+44+55+110 = 284 'dür.
 * 284 kendisi hariç pozitif bölenler toplamı => 1+2+4+71+142 = 220 'dir.
*/

FriendlyNumber();

Console.ReadKey();
static void FriendlyNumber()
{
    Console.WriteLine("Birinci sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("İkinci sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());
    Console.WriteLine("=============================");
    Console.WriteLine();

    int sayi1BolenToplam = 0;
    int sayi2BolenToplam = 0;
    for (int i = 1; i <= sayi1 / 2; i++)
    {
        if (sayi1 % i == 0)
        {
            sayi1BolenToplam += i;
        }
    }
    for (int i = 1; i <= sayi2 / 2; i++)
    {
        if (sayi2 % i == 0)
        {
            sayi2BolenToplam += i;
        }
    }
    if (sayi1BolenToplam == sayi2 && sayi2BolenToplam == sayi1)
    {
        Console.WriteLine($"{sayi1} ve {sayi2} Arkadaş Sayıdır.");
    }
    else
    {
        Console.WriteLine($"{sayi1} ve {sayi2} Arkadaş Sayı Değildir! ");
    }
}