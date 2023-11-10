//Soru-3   Bir string içerisindeki karakter sayısını veren bir C# programı yazın
//Örnenk:  Tobeto -> t:2, o:2, b:1, e:1

Console.WriteLine("Bir metin giriniz");
string metin = Console.ReadLine();

string karakterTutucu = "";
foreach (char karakter in metin)
{
    if (!karakterTutucu.Contains(karakter))
        karakterTutucu = karakterTutucu + karakter;
}

foreach (var karakter in karakterTutucu)
{
    int sayac = 0;
    for (int i = 0; i < metin.Length; i++)
        if (karakter == metin[i])
            sayac++;
    Console.WriteLine($"{karakter} : {sayac}");
}

Console.ReadKey();