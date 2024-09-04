int number = 6;

for (int i = 1; i <= number; i++)
{
    // Print leading spaces
    for (int j = 1; j <= number - i; j++)
    {
        Console.Write(" ");
    }

    // Print the "A" characters
    for (int j = 1; j <= i; j++)
    {
        Console.Write("A ");
    }

    // Move to the next line
    Console.WriteLine();
}
