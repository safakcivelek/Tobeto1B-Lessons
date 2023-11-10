//Soru-4 (V1.1) İki String'in birbirinin anagramı olup olmadığı nasıl kontrol edilir?

//Anagram, bir kelimenin ya da kelime grubunun içinde yer alan harflerin yerini değiştirerek yeni bir anlam kazanılmasına denir.
//Aynı sözcüğünün harflerini değiştirerek farklı bir sözcük oluşturulması olayıdır.
//Örnek: açlık, çalık, çakıl, laçkı, kalıç, kaçlı, akçıl 

AnagramV1_1();
static void AnagramV1_1()
{
    Console.Write("1.Kelimeyi giriniz: ");
    string kelime1 = Console.ReadLine();
    Console.WriteLine();
    Console.Write("2.Kelimeyi giriniz: ");
    string kelime2 = Console.ReadLine();

    KarakterUzunlukKontrol(kelime1, kelime2);

    int sayac = 0;
    for (int i = 0; i < kelime1.Length; i++)
    {
        for (int j = 0; j < kelime2.Length; j++)
        {
            if (kelime1[i] == kelime2[j])
                sayac++;
        }
    }
    Console.WriteLine();
    if (sayac == kelime1.Length)
        Console.WriteLine("Evet bu kelimeler Anagram'dır. ({0}-{1})", kelime1, kelime2);
    else
        Console.WriteLine("Hayır bu kelimeler Anagram DEĞİLDİR!!! ({0}-{1})", kelime1, kelime2);

    Console.ReadKey();

    #region Karakter Uzunluk Kontrol Metodu
    static void KarakterUzunlukKontrol(string kelime1, string kelime2)
    {
        while (kelime1.Length != kelime2.Length)
        {
            Console.WriteLine();
            Console.WriteLine($"Bu sayılar Anagram DEĞİLDİR! Çünkü {kelime1} ve {kelime2}'nin uzunlukları eşit değildir!!!");
            Console.WriteLine("Lütfen tekrar deneyiniz!!!");
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.Write("1.Kelimeyi giriniz: ");
            kelime1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("2.Kelimeyi giriniz: ");
            kelime2 = Console.ReadLine();
        }
    }
    #endregion
}

//Soru-4 (V1.2)   İki String'in birbirinin anagramı olup olmadığı nasıl kontrol edilir?
//AnagramV1_2();
static void AnagramV1_2()
{
    Console.WriteLine("Birinci metni giriniz: ");
    string str1 = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("İkinci metni giriniz: ");
    string str2 = Console.ReadLine();

    Console.WriteLine();

    char[] char1 = str1.ToLower().ToCharArray();
    Array.Sort(char1);

    char[] char2 = str2.ToLower().ToCharArray();
    Array.Sort(char2);

    string kelime1 = new string(char1);
    string kelime2 = new string(char2);

    if (kelime1 == kelime2)
    {
        Console.WriteLine("Evet bu ({0}-{1}) kelimeler Anagram'dır.", str1, str2);
    }
    else
    {
        Console.WriteLine("Hayır bu ({0}-{1}) kelimeler Anagram DEĞİL !!!", str1, str2);
    }
    Console.ReadKey();
}
