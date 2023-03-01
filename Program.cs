Console.WriteLine("Введите массив целых чисел через пробел:");
string temp = Console.ReadLine()!;
string[] array = temp.Split(" ");


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

void PrintArray(string[] array1)
{
    System.Console.Write($"[{String.Join(",", array1)}]");
}

PrintArray(newArray);