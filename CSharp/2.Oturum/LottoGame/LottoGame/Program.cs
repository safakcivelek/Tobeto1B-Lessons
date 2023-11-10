
// Loto Şans Oyunu

#region Kurallar
/* Açıklama:
* Her oyun da en az 1 en fazla 8 deneme şansınız var.
* Her deneme 1 satırdan oluşur ve her satır da 6 adet stun vardır.
* 1-49 arası seçilen sayılar bu stunlara yerleşicek.
* Herhangi bir  satırda seçilen sayılar birbirinden farklı olmak zorunda.
* Fakat bir stundaki bir sayı başka bir stunda bulunabilir.
* Tüm satırlar int array olmak zorunda.
* Örnek;  1.satır => 2,6,15,18,45,48
* Örnek;  2.satır => 4,6,18,19,43,49
* Örnek;  3.satır => 1,6,15,25,45,48
*/
#endregion

Console.WriteLine(">>> Sayısal Loto Oyununa Hoş Geldiniz! <<<");
Console.WriteLine("******************************************");
Console.WriteLine();

Console.WriteLine("# Şansınızı kaç defa denemek istersiniz? (1-8 arası)");
int columnCount = int.Parse(Console.ReadLine());

Random random = new Random();
bool flag = false;

while (columnCount < 1 || columnCount > 8)
{
    Console.WriteLine("Lütfen 1 ve 8 arası bir değer giriniz!");
    columnCount = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine(">>> Sayısal Loto Oyununa Hoş Geldiniz! <<<");
    Console.WriteLine("******************************************");
    Console.WriteLine();
}

int[,] LotoNumbers = new int[columnCount, 6];

for (int i = 0; i < columnCount; i++)
{
    for (int j = 0; j < 6; j++)
    {
        var randomNumber = random.Next(1, 50);

        flag = false;
        for (int k = 0; k < j + 1; k++)
        {
            if (true)
            {

            }
            if (randomNumber == LotoNumbers[i, k])
            {
                flag = true;
                break;
            }
        }
        if (flag == true)
            j--;
        else
            LotoNumbers[i, j] = randomNumber;
    }
}
Console.WriteLine("Loto Numaralarınız Aşağıdadır!");
Console.WriteLine("------------------------------");
for (int i = 0; i < columnCount; i++)
{
    Console.WriteLine();
    for (int j = 0; j < 6; j++)
    {
        if (j == 0)
        {
            Console.Write($"{i + 1}.Loto => ");
        }
        Console.Write(LotoNumbers[i, j]);
        if (j != 5)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("\nÇekiliş Sonucu Aşağıdadır!");
Console.WriteLine("----------------------------");
int[] result = new int[6];
for (int i = 0; i < 6; i++)
{
    result[i] = random.Next(1, 50);
    Console.Write(result[i] + ", ");
}

Console.ReadLine();
// devam edilecek!
// çekiliş sonucu olsun sonuclar karşılaştırılsın! 