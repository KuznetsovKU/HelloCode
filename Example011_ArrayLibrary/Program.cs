void fillArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void printArray (int [] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.Write($"{coll[index]} ");
        index++;
    }
}

int indexOff (int [] collection, int findedNum)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;
    while (index < length)
    {
        if (collection[index] == findedNum)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] numArray = new int [10];

fillArray(numArray);
System.Console.Write("Введите искомое число: ");
int findedNum = Convert.ToInt32(Console.ReadLine());
printArray(numArray);
System.Console.WriteLine();

int position = indexOff(numArray, findedNum);
if (position >= 0)
{
    System.Console.WriteLine($"Индекс искомого числа: {position}");
}
else
{
    System.Console.WriteLine("No matches. Sorry");
}