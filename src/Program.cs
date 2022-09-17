Console.Write("Введите строки через пробел или запятую: ");
string? s = Console.ReadLine();
string[] array = s.Split(',', ' ').ToArray();
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) 
    {
        count++;
    }
}
string[] result = new string[count];
count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) 
    {
        result[count] = array[i];
        count++;
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (i == 0) 
    {
        Console.Write($"[{array[i]}, ");
    }
    else if (i < array.Length -1) 
    {
        Console.Write($"{array[i]}, ");
    }

    else Console.Write($"{array[i]}] -> ");
    
}
for (int i = 0; i < result.Length; i++)
{
    if (i == 0) 
    {
        Console.Write($"[{result[i]}, ");
    }
    else if (i < result.Length -1)
    {
        Console.Write($"{result[i]}, ");
    }

    else Console.Write($"{result[i]}]");
}
