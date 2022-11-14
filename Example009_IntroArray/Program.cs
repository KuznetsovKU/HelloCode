int findMax (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int [] numArray = {14, 62, 93, 46, 532, 65, 74, 38, 79};

int max = findMax(
    findMax(numArray[0], numArray[1], numArray[2]),
    findMax(numArray[3], numArray[4], numArray[5]),
    findMax(numArray[6], numArray[7], numArray[8])
);

System.Console.WriteLine(max);