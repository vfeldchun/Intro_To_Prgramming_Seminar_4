// Задача 3: 
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

class Programm
{
    static void Main()
    {
        Console.Write("Введите количество случайных чисел в маcсиве: ");
        int n = Convert.ToInt32(Console.ReadLine());   

        int[] arrOfNums = GetArrayOfRandomNumbers(n);
        PrintArray(arrOfNums);

        Console.WriteLine("Перевернутый маcсиве: ");
        ArrayRevert(arrOfNums);
        PrintArray(arrOfNums);
        
        void ArrayRevert(int[] arrOfNums)
        {
            int tempNumber;

            if (arrOfNums.Length == 1) return;

            for (int i = 0; i < arrOfNums.Length / 2; i++)
            {
                tempNumber = arrOfNums[i];
                arrOfNums[i] = arrOfNums[^(i+1)];
                arrOfNums[^(i+1)] = tempNumber;
            }
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
                arrayOfNumbers[i] = rand.Next(1, 100);
            }

            return arrayOfNumbers;
        }
    }
}