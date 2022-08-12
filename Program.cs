string [] Symbols = new string [5]
{
    "sjkdfl", "123", "igj", "poemr", "1"
};

void GetArray(string[] array)
{
    string count;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            count = array[i];
            Console.Write(count + " ");
        }
    }
    Console.WriteLine();
}

GetArray(Symbols);

