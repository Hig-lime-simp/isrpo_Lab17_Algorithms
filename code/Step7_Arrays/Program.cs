Console.WriteLine("=== Массив оценок студента ===");
            
            int[] marks = { 5, 4, 5, 3, 4 };
            
            Console.WriteLine("Индекс\tЗначение");
            Console.WriteLine("--------------");
            
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"{i}\t{marks[i]}");
            }
            
            Console.WriteLine("\nКонец программы");
            Console.ReadKey();

            Console.WriteLine("=== Поиск максимальной оценки ===");
            
            int[] marks = { 5, 4, 5, 3, 4 };
            
            Console.WriteLine("Массив оценок:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            
            Console.WriteLine("\n\nИщем максимальный элемент...");
            
            int max = marks[0]; 
            
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                    Console.WriteLine($"Найден новый максимум: {max} (индекс {i})");
                }
            }
            
            Console.WriteLine($"\nМаксимальная оценка: {max}");
            Console.WriteLine("Конец программы");
            Console.ReadKey();