
            double[] GenerateRandomArray(int size)
            {
                double[] randomArray = new double[size];
                Random random = new Random();

                for (int i = 0; i < size; i++)
                {
                    randomArray[i] = random.NextDouble() * 10; 
                }

                return randomArray;
            }

            double FindMax(double[] array)
            {
                double max = array[0];
                foreach (double num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return max;
            }

            double FindMin(double[] array)
            {
                double min = array[0];
                foreach (double num in array)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            }

            int arraySize = 5;
            double[] randomArray = GenerateRandomArray(arraySize);

            Console.WriteLine("Сгенерированный массив:");
            foreach (double num in randomArray)
            {
                Console.Write(num + " ");
            }

            double maxElement = FindMax(randomArray);
            double minElement = FindMin(randomArray);
            double difference = maxElement - minElement;
            Console.WriteLine("\nРазница между максимальным и минимальным элементами: " + difference);
        