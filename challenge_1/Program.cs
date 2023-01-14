/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

int numA = GetNumbetFromUserA("Введите целоечисло А: ", " Ошибка ввода!");
int numB = GetNumbetFromUserB("Введите целоечисло B: ", " Ошибка ввода!");
int resultNumbers = GetResultNumbers(numA);
Console.WriteLine($"{numA}, {numB} -> {resultNumbers}");

int GetNumbetFromUserA(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
int GetNumbetFromUserB(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetResultNumbers(int num1, num2)
{
    int count = 1;
    while (numB <= count)
    {
        numA = numA * numA;
        count++;
    }
    return num;
}
