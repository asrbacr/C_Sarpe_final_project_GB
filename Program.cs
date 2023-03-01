Console.WriteLine("Введите строчные данные с которыми будет работать программа, отделяя элементы пробелами:");
string temp = Console.ReadLine()!;
string[] array = temp.Split(" ");

System.Console.WriteLine();
System.Console.Write("Получился массив: ");
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine("Программа отобрала и сформировала новый массив на условии, что длина элемента меньше либо равно 3:");
PrintArray(SerchMalZnach(array));

//__func

string[] SerchMalZnach(string[] array)
{
    int newArrayLight = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newArrayLight++;
    }

    string[] newArray = new string[newArrayLight];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array1)
{
    System.Console.Write($"[{String.Join(", ", array1)}]");
}

