namespace HomeWork5Library
{
    public class HomeWork5
    {
        public static void MaxDigits(string ReceivedString)
        {
            string[] str = ReceivedString.Split(" ");
            int MaxDigits = 0;
            int Index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int CounterMemory = 0;
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (char.IsNumber(str[i][j]))
                    {
                        CounterMemory++;
                    }
                    if (CounterMemory > MaxDigits)
                    {
                        MaxDigits = CounterMemory;
                        Index = i;
                    }
                }
            }
            if (MaxDigits > 0)
                Console.WriteLine("Больше всего цифр в слове " + str[Index]);
            else
            {
                Console.WriteLine("в словах нет цифр");
            }
        }
        public static void LengthWord(string ReceivedString)
        {
            string[] str = ReceivedString.Split(" ");
            string LengthWord = " ";
            int RepetitionCounter = 0;
            int repetition = 0;
            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if
                (str[i].Length > a)
                {
                    a = str[i].Length;
                    LengthWord = str[i];
                }
            }
            foreach (string i in str)
            {
                if (LengthWord.CompareTo(i) == 0)
                {
                    repetition++;
                }
                if (LengthWord.Length == i.Length)
                {
                    RepetitionCounter++;
                }
            }
            Console.WriteLine($"Самое длинное слово {LengthWord} Слов такой длинны: {RepetitionCounter}\n Количество повторений этого слова: {repetition}");
        }
        public static void ReplacingNumbers(string ReceivedString)
        {
            for (int i = 0; i <= 9; i++)
            {
                string s = Convert.ToString(i);
                string s1 = Convert.ToString(i);
                switch (i)
                {
                    case 0:
                        {
                            s1 = "Ноль";
                            break;
                        }
                    case 1:
                        {
                            s1 = "Один";
                            break;
                        }
                    case 2:
                        {
                            s1 = "Два";
                            break;
                        }
                    case 3:
                        {
                            s1 = "Три";
                            break;
                        }
                    case 4:
                        {
                            s1 = "Четыре";
                            break;
                        }
                    case 5:
                        {
                            s1 = "Пять";
                            break;
                        }
                    case 6:
                        {
                            s1 = "Шесть";
                            break;
                        }
                    case 7:
                        {
                            s1 = "Семь";
                            break;
                        }
                    case 8:
                        {
                            s1 = "Восемь";
                            break;
                        }
                    case 9:
                        {
                            s1 = "Девять";
                            break;
                        }

                }

                ReceivedString = ReceivedString.Replace(s, s1);
            }

            Console.WriteLine(ReceivedString);
        }
    }
}
