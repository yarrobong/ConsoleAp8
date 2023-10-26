Console.WriteLine("Введите строку для проверки:");
string str = Console.ReadLine();

bool isValidOctalNumber = true;

if (string.IsNullOrWhiteSpace(str))
{
    isValidOctalNumber = false;
}
else
{
    foreach (char digit in str)
    {
        if (digit < '0' || digit > '7')
        {
            isValidOctalNumber = false;
            break;
        }
    }
}

if (isValidOctalNumber)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}