Random randomNumber = new Random();

int lowerRandomNumber = 0;
int upperRandomNumber = 15;

string[] firstStringArray = new string[randomNumber.Next(lowerRandomNumber, upperRandomNumber)];
string[] secondStringArray = new string[randomNumber.Next(lowerRandomNumber, upperRandomNumber)];

FillArray(firstStringArray, randomNumber, lowerRandomNumber, upperRandomNumber);
FillArray(secondStringArray, randomNumber, lowerRandomNumber, upperRandomNumber);

List<string> colletionsNumbers = new List<string>();

for (int i = 0; i < firstStringArray.Length; i++)
{
    colletionsNumbers.Add(firstStringArray[i]);
}

for (int i = 0; i < secondStringArray.Length; i++)
{
    colletionsNumbers.Add(secondStringArray[i]);
}

for (int i = 0; i < colletionsNumbers.Count; i++)
{
    for (int j = i + 1; j < colletionsNumbers.Count; j++)
    {
        if (colletionsNumbers[j] == colletionsNumbers[i])
        {
            colletionsNumbers.RemoveAt(j);
        }
    }
}

Console.Write("Первый массив строк: ");

foreach (string number in firstStringArray)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.Write("ВТорой массив строк: ");

foreach (string number in secondStringArray)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.Write("Результат: ");

foreach (string number in colletionsNumbers)
{
    Console.Write(number + " ");
}

static void FillArray(string[] array, Random randomNumber, int lowerRandomNumber, int upperRandomNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(randomNumber.Next(lowerRandomNumber, upperRandomNumber));
    }
}