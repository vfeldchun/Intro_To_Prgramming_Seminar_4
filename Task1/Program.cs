// Задача 1: 
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

class Programm
{
    static void Main()
    {

        string? numberString = "";

        while (true) 
        {
            Console.Write("Введите целое число или нажмите 'q': ");
            numberString = Console.ReadLine();
            if (numberString == "q" || IsNumbersSumEven(numberString)) break;
        }

    
        bool IsNumbersSumEven(string? numberString)
        {
            int number;

            try
            {
                number = Convert.ToInt32(numberString);
            }
            catch
            {
                Console.WriteLine("Ошибка в вводе целого числа");
                return false;
            }

            if (number < 0) number = -number;

            // Исходя из условия задачи число должно быть минимум двухзначным
            if (number > 9)
            {
                int sum = GetNumberElemantSum(number.ToString());
                if (sum % 2 == 0) return true;
            }

            return false;
        }

        int GetNumberElemantSum(string numberString)
        {
            int sum = 0;
            foreach(var digit in numberString)
            {
                sum = sum + Convert.ToInt32(digit);
            }

            return sum;
        }
    }
}