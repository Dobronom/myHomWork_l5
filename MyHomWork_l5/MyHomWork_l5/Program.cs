using System;
using HomeWork5Library;

Console.WriteLine("введите любую строку");
string ReceivedString  = Console.ReadLine();
int a = 1;
Console.WriteLine("Чтоб найти слова, содержащие максимальное количество цифр введите 1!\nЧтоб найти самое длинное слово и определить, сколько раз оно встретилось в тексте введите 2!\nЧтоб заменить цифры от 0 до 9 на слова «ноль», «один», …, «девять» введите 3!");
try
{
    while (a != 0)
    {  
        int c = Convert.ToInt32(Console.ReadLine());
        switch (c)
        {
            case 1:
                {
                    HomeWork5.MaxDigits(ReceivedString);
                    break;
                }
            case 2:
                {
                    HomeWork5.LengthWord(ReceivedString);
                    break;
                }
            case 3:
                {
                    HomeWork5.ReplacingNumbers(ReceivedString);
                    break;
                }
        }
        Console.WriteLine("Если желаете выйти введите 0.\nЧтоб продолжиь любую другую цифру.");
        a = Convert.ToInt32(Console.ReadLine());
        if (a != 0)
        {
            Console.WriteLine("выберите команду.");
        }


       
    }
}
catch
{
    Console.WriteLine("Ошибка ввода. Приложение будет закрыто");
}






