 int[] GenerateRandomArray(int size)
            {
                int[] randomArray = new int[size];
                Random random = new Random();

                for (int i = 0; i < size; i++)
                {
                    randomArray[i] = random.Next(100, 1000);
                }

                return randomArray;
            }

int CountEvenNumbers(int[] array)
            {
                int count = 0;
                foreach (int num in array)
                {
                    if (num % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }


 int arraySize = 5;
    int[] randomArray = GenerateRandomArray(arraySize);
            Console.WriteLine("Сгенерированный массив:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }

            int evenCount = CountEvenNumbers(randomArray);
            Console.WriteLine("\nКоличество четных чисел в массиве: " + evenCount); 