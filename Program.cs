// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

void Decision(string[] arrayD, string[] arrayR)
{
    int count = 0;
    for (int i = 0; i < arrayD.Length; i++)
    {
    if(arrayD[i].Length <= 3)
        {
        arrayR[count] = arrayD[i];
        count++;
        }
    }
}

void Result(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arrayDecision = new string[5] {"333", "96", "Ethereum", "Solana", "Ton"};
string[] arrayResult = new string[arrayDecision.Length];

Decision(arrayDecision, arrayResult);
Result(arrayResult);