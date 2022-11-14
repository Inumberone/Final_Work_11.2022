// Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше, либо равна 3



string[] array = new string[] {"line", "rows", "columns", "int", "log", "graph", "dot", "net"};
string[] array1 = new string[array.Length];

GetArray(array, array1);
PrintArray(array);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();

void GetArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }    
}