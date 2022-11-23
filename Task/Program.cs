void Main()
{   
    Console.Clear();
    string[] first_array = new string[4] {"hello", "2", "world", ":-)"};
    string[] second_array = new string[first_array.Length];
    CreateResultArrayWithIf(first_array, second_array);
    PrintArray(second_array);
}

void CreateResultArrayWithIf(string[] first_array, string[] second_array)
{
    int count = 0;
    for (int i = 0; i < first_array.Length; i++)
    {
    if(first_array[i].Length <= 3)
        {
        second_array[count] = first_array[i];
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
    Console.WriteLine();
}

Main();
