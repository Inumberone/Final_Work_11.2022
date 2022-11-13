int[] numbers = new int[5];

for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(-100,100);
}
   
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + ",");
}
Console.WriteLine();

int count = 0;
for(int j = 0; j < numbers.Length; j++)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.WriteLine();
}

