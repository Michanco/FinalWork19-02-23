// Задача. Написать программу, которая из имеющегося массива строк 
// формирует массив из строк , длина которых меньше либо равна 3 символа.

Console.WriteLine("Введите количество элементов");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = InputArray(size);
int finArrayLength = FinArrayLengthFind(array);
if (finArrayLength == 0) Console.WriteLine("Среди введённых элементов нет элементов с 3 мя и менее символов");
else
{
    string[] finArray = StringsThreeSymbol(array, finArrayLength);
    PrintArray(finArray);
}

int FinArrayLengthFind(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] StringsThreeSymbol(string[] arr, int siz)
{
    int j = 0;
    string[] arrThree = new string[siz];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrThree[j] = arr[i];
            j++;
        }
    }
    return arrThree;
}

string[] InputArray(int siz)
{
    string[] arr = new string[siz];
    for (int i = 0; i < siz; i++)
    {
        Console.WriteLine($" Элемент № {i + 1}");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($" ' {arr[i]} ', ");
    }
    Console.Write($"  ' {arr[arr.Length - 1]} '  ]");
    Console.WriteLine();
}