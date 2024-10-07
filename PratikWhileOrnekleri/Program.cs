
// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int sayac = 1;
while (sayac <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac++;
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int count=1;
while (count < 20)
{
    Console.Write($"{count}  ");
    count++;
}

Console.WriteLine();

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int countCift=1;
while(countCift < 20)
{
    if (countCift % 2 == 0)
    {
        Console.Write($"{countCift}  ");
    }
    countCift++;
}
Console.WriteLine();

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int sum =0;
int sumCount = 50;
while (sumCount < 150 )
{
    sum += sumCount;
    sumCount++;
}
Console.WriteLine($"sayıların toplamı: {sum}");

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int sayacCift = 0;
int sayacTek =0;
int sayacFull = 1;
while (sayacFull < 120)
{
    if (sayacFull % 2 == 0)
    {
        sayacCift += sayacFull;
    }
    else
    {
        sayacTek += sayacFull;
    }
    sayacFull++;
}

Console.WriteLine($"çift sayılar toplamı: {sayacCift}");
Console.WriteLine($"tek sayılar toplamı: {sayacTek}");