// Задача 2: 
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

class Programm
{
    static void Main()
    {
        Console.Write("Введите количество случайных трехзначных чисел в маcсиве: ");
        int n = Convert.ToInt32(Console.ReadLine());   

        int[] arrOfNums = GetArrayOfRandomNumbers(n);
        PrintArray(arrOfNums);

        int evenNumberCount = GetEvenNumbersCountInArray(arrOfNums);

        Console.WriteLine($"Количество четных элементов в массиве: {evenNumberCount}");

        int GetEvenNumbersCountInArray(int[] arrayOfNumbers)
        {
            int countEvenNumber = 0;
            int oneDigit;

            foreach(int number in arrayOfNumbers)
            {   
                int tempNumber = number;

                for(int i=0; i < 3; i++)
                {
                    oneDigit = tempNumber % 10;
                    tempNumber = (int)(tempNumber / 10);
                    // 0 - то же четное число
                    if (oneDigit % 2 == 0) countEvenNumber++;
                }
            }

            return countEvenNumber;
        }

        void PrintArray(int[] arrOfNums)
        {
            Console.Write("{ ");
            foreach (var number in arrOfNums)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("}");
        }

        int[] GetArrayOfRandomNumbers(int lenOfArray)
        {
            int[] arrayOfNumbers = new int[lenOfArray];
            var rand = new Random();
            
            for (int i = 0; i < lenOfArray; i++)
            {
                arrayOfNumbers[i] = rand.Next(100, 1000);
            }

            return arrayOfNumbers;
        }
    }
}