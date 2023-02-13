
string[] array = { "a", "one", "b", "two", "q", "много", "hello" };

int LengthCount(string[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int size = array[i].Length;
        if (size <= 3) number++;
    }
    return number;
}

int sizeArray = LengthCount(array);

string[] CreatinAnArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int p = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int count = array[i].Length;
        if (count <= 3)
        {
            newArray[p] = array[i];
            p++;
        }

    }
    return newArray;
}

string[] newArray = CreatinAnArray(array, sizeArray);

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Print(array);
Console.WriteLine();
Print(newArray);