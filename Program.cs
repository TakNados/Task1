for (int i = 1; i < 100; i++)
{
    if (i % 15 == 0) Console.WriteLine("FIZZbuzz");
    else if (i % 3 == 0) Console.WriteLine("FIZZ");
    else if (i % 5 == 0) Console.WriteLine("BUZZ");
    else Console.WriteLine(i);
}