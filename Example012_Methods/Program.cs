// Виды методов (подпрограмм)

/*
#region Вид 1: Ничего не принимает на вход, ничего не возвращает через return (void)

void Method_1()  // Метод не принимает на вход никаких аргументов
{
    System.Console.WriteLine("например Какой-то текст");  // Метод не содержит return, может выводить что-то в консоль, или просто производить некоторые операции внутри себя
}

Method_1();  // Вызов Метода обязательно со скобками (даже, если метод не принимает аргументов)

#endregion


#region Вид 2: Принимает на вход некоторые аргументы, но ничего не возвращает через return (void)

void Method_2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
    
}

Method_2("Текст сообщения", 2);           // При вызове Метода передаем аргумент в скобках
Method_2(count: 2, msg: "Просто текст");  // При использовании ИМЕНОВАННЫХ аргументов, можно перезавать их в любом порядке
    
#endregion


#region Вид 3: Ничего не принимает на вход, что-то возвращает через return (НЕ void)

int Method_3()
{
    return DateTime.Now.Year;  //  оператор return обязателен для НЕ-void методов
}

int year = Method_3();  // результат вызова Метода присваиваем какой-либо переменной
System.Console.WriteLine(year);

System.Console.WriteLine(Method_3());  // альтернативный вариант вывода результата вывода Метода (прямо в консоль)
    
#endregion


#region Вид 4: Принимает на вход некоторые аргументы, что-то возвращает через return (НЕ void)

string Method_4(int count, string text)
{
    
    string result = String.Empty;  // более правильный вариант объявления пустой строки в сравнении с ... = ""
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}

string res =  Method_4(10, "asdf");            // Присваивание результата вызова Метода некоторой переменной
System.Console.WriteLine(res);                 // Вывод в консоль значения переменной

System.Console.WriteLine(Method_4(2, "abC"));  // Вывод в консоль результата вызова Метода
    
#endregion
*/

/*
#region Задача с заменой символов в тексте

// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);

#endregion
*/

#region Задача с сортировкой массива

int [] array = {6, 8, 3, 2, 1, 4, 5, 7, 1, 1, 2};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(array);

void Sort_To_Max(int [] array)  // Сортировка от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int startPosition = i;             // Вводим переменную для фиксации первого НЕотсортированного значения
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[startPosition])  // если НЕотсортированное значение < первого НЕотсортированного
            {
                startPosition = j;                // первое НЕотсортированное значение == текущее (минимальное) значение из НЕотсортированных
            }
        }

        int temporary = array[i];          // Вводим переменную для временного хранения первого НЕотсортированного значения 
        array[i] = array[startPosition];   // меняем местами значения массива (меньший индекс -> меньшее значение)
        array[startPosition] = temporary;  // меняем местами значения массива (больший индекс -> большее значение)
    }
}

Sort_To_Max(array);
PrintArray(array);

void Sort_To_Min(int [] array)  // Сортировка от большего к меньшему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int startPosition = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] > array[startPosition]) startPosition = j;
        }
        int temporary = array[i];
        array[i] = array[startPosition];
        array[startPosition] = temporary;
    }
}

Sort_To_Min(array);
PrintArray(array);

#endregion