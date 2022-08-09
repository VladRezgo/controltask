string [] ArrayArbitrary (string [] arr)
{
    string [] newarray = new string [arr.Length];
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarray[n] = arr[i];
            n++;
        }
    }
    return newarray;
}

void PrintArray (string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]+"  ");
    }
}

Console.Write("Введите кол-во элементов длины массива ");
int num = Convert.ToInt32(Console.ReadLine());
string [] array = new string [num];
for (int i = 0; i < num; i++)
{
   Console.Write($"введите {i+1}  элемент массива, он может быть как числовой, так и текстовый  ");
   array[i] = Console.ReadLine();
}
Console.WriteLine("Массив длиной  3-х и менее символов ->  ");
PrintArray(ArrayArbitrary(array));