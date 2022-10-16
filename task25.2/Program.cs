void number(int fNumber, int sNumber)
{
    int result = 1;
    for (int newNumber = 1; newNumber <= sNumber; newNumber++)
    {
        result = result * fNumber;
    }
    Console.WriteLine(result);
}

number(89, 7);