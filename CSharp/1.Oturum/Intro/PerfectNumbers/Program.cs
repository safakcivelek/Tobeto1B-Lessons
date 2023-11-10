//Soru-3   2 - 1000 arasındaki süper sayıları listeleyen programı yazınız.

// Mükemmel Sayı => Kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayıya Mükemmel sayı denir.
// Örnek;  6 --> 1,2,3 =>   1+2+3 = 6 

PerfectNumbers();
Console.ReadKey();

static void PerfectNumbers()
{
    Console.WriteLine("2 ile 1000 Arasındaki Mükemmel Sayılar Listeleniyor");
    Console.WriteLine("===================================================");
    for (int i = 2; i <= 1000; i++)
    {
        int bolenler = 0;
        for (int j = 1; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                bolenler += j;
            }
        }
        if (bolenler == i)
        {
            Console.WriteLine($"{i} Mükemmel Sayıdır.");
        }
    }
}

