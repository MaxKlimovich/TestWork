
string[] daysOfWeek = {"Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday", "Sunday" };

void PrintDays(string[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("] -> ");
}

void PrintThreeDays(string[] arr)
{
    Console.Write("[");
    int count = new Random().Next(0, 3);
    for (int i = 0; i <= count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}


PrintDays(daysOfWeek);
PrintThreeDays(daysOfWeek);




