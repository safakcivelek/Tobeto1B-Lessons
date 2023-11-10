////Soru-5 V1.1   Dizenin tüm benzersiz karakterlere sahip olup olmadığı nasıl belirlenir.

//Console.Write(">>> Lütfen bir metin giriniz : ");
//string metin = Console.ReadLine();
//Console.WriteLine();

//HashSet<char> karakterDizisi = new HashSet<char>();
//bool uniqueMi = true;
//foreach (var karakter in metin)
//{
//    if (karakterDizisi.Add(karakter) == true)
//    {
//        uniqueMi = true;
//    }
//    else
//    {
//        uniqueMi = false;
//        Console.WriteLine("!!! Hayır, Unique DEĞİL");
//        break;
//    }
//}
//if (uniqueMi != false)
//{
//    Console.WriteLine("-> Evet, bu karakterler Unique'dir");
//}
//Console.ReadLine();

//***************************************************//

////Soru-5 V1.2   Dizenin tüm benzersiz karakterlere sahip olup olmadığı nasıl belirlenir.

//Console.WriteLine("Enter a string");
//string metin = Console.ReadLine();

//metin = metin.ToUpper();
//bool sayac = false;

//for (int i = 0; i < metin.Length; i++)
//{
//    for (int j = 0; j < metin.Length; j++)
//    {
//        if (metin[i] == metin[j])
//        {
//            if (i < j)
//            {
//                sayac = true;
//                break;
//            }

//        }
//    }
//}
//if (sayac)
//    Console.WriteLine("Not Unique");
//else
//    Console.WriteLine("Unique");

//Console.ReadLine();

//***************************************************//

//Soru-5 V1.3   Dizenin tüm benzersiz karakterlere sahip olup olmadığı nasıl belirlenir.
Console.WriteLine();
Console.Write("Lütfen bir metin giriniz : ");
string metin = Console.ReadLine();
Console.WriteLine("-------------------------------");
Console.WriteLine();

metin = metin.ToLower();
bool state = false;
for (int i = 0; i < metin.Length - 1; i++)
{
    for (int j = i + 1; j < metin.Length; j++)
    {
        if (metin[i] == metin[j])
        {
            state = true;
            Console.WriteLine("Hayır, Bu metin Unique değil!!!");
            break;
        }
    }
    if (state == true)
        break;
}
if (state == false)
{
    Console.WriteLine("Evet, Bu metin Unique.");
}
Console.ReadLine();