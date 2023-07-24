int[] GenerateRandomArray(int size)
            {
                int[] randomArray = new int[size];
                Random random = new Random();

                for (int i = 0; i < size; i++)
                {
                    randomArray[i] = random.Next(1, 100); 
                }

                return randomArray;
            }

            int SumElementsAtOddPositions(int[] array)
            {
                int sum = 0;
                for (int i = 1; i < array.Length; i += 2)
                {
                    sum += array[i];
                }
                return sum;
            }

            int arraySize = 4;
            int[] randomArray = GenerateRandomArray(arraySize);

            Console.WriteLine("Сгенерированный массив:");
            foreach (int num in randomArray)
            {
                Console.Write(num + " ");
            }

            int sumOddPositionElements = SumElementsAtOddPositions(randomArray);
            Console.WriteLine("\nСумма элементов на нечетных позициях: " + sumOddPositionElements);