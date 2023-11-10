//Soru-6  İlk iki arkadaş sayıları bulan bir c# programı yazın.(Çıkış: 1-> 220-284 2: 1184-1210)
/*
 * Arkadaş Sayılar : İki sayının kendileri hariç pozitif bölenleri toplamı birbirlerine eşitse bu sayılar arkadaş sayı olarak adlandırılır. 
 * Örneğin 220 ve 284 sayıları bir çift arkadaş sayıdır.
 * 220 kendisi hariç pozitif bölenler toplamı => 1+2+4+5+10+11+20+22+44+55+110 = 284 'dür.
 * 284 kendisi hariç pozitif bölenler toplamı => 1+2+4+71+142 = 220 'dir.
*/

Console.WriteLine();
Console.WriteLine(">>> Bu Program İlk İki Arkadaş Sayı Çiftini Listeler <<<");
Console.WriteLine("********************************************************");
Console.WriteLine();

int sayac = 0;
for (int sayi1 = 1; sayac < 10; sayi1++)
{
    int sayi1BolenToplam = 0;
    for (int i = 1; i <= sayi1 / 2; i++)
    {
        if (sayi1 % i == 0)
        {
            sayi1BolenToplam += i;
        }
    }
    int sayi2 = sayi1BolenToplam;

    int sayi2BolenToplam = 0;
    for (int j = 1; j <= sayi2 / 2; j++)
    {
        if (sayi2 % j == 0)
        {
            sayi2BolenToplam += j;
        }
    }
    if (sayi1 != sayi2 && sayi2BolenToplam == sayi1)
    {
        sayac++;
        Console.WriteLine($"{sayac}.Arkadaş Sayı Çifti : {sayi1} ve {sayi2}");
        Console.WriteLine();
        sayi1 = sayi2; // aynı çifti tekrar almasını engeller
    }
}
Console.WriteLine("*** FINISHED ***");
Console.ReadLine();


