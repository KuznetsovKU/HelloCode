int [] numArray = {1, 32, 13, 64, 75, 46, 27, 18};

int length = numArray.Length;
System.Console.Write("Введите искомое число: ");
int foundedNum = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < length)
{
    if (numArray[index] == foundedNum)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
