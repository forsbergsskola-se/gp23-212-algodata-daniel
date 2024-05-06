using System.Collections;

double sum = 0;
foreach (var number in GetABillionNumbersList())
{
    sum += number;
}

Console.WriteLine(sum);

// 20 bytes of RAM
IEnumerable<int> GetABillionNumbers()
{
    for (int i = 0; i < 2_000_000_000; i++)
    {
        yield return i;
    }
}

// at least 8 gigabytes of RAM
IEnumerable<int> GetABillionNumbersList()
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < 2_000_000_000; i++)
    {
        numbers.Add(i);
    }

    return numbers;
}