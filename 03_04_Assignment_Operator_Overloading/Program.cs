using System;

/*
Источник: https://metanit.com/

Как известно, неотъемлемыми компонентами бутерброда являются хлеб и масло.
Допустим, у нас есть классы Bread, Butter, Sandwich.
Добавьте в один из классов оператор сложения, чтобы при объединении хлеба (Bread) и масла (Butter)
получался бутерброд (Sandwich), и, тем самым, компилировался и выполнялся без ошибок код в методе Main.

Тестирование приложения выполняется путем запуска разных наборов тестов, например,
на вход может поступить строка (веса компонентов бутерброда, разделенные через пробел):
10 10
Программа должна вывести на экран:
20
Никаких дополнительных символов выводиться не должно.

Код метода Main оставить без изменений (если очень хочется, то можно навести красоту и убрать,
например, Parse, но в этой задаче неккоректных данных не будет).
*/

namespace Task01
{
    class Bread
    {
        public int Weight { get; set; }
    }
    class Butter
    {
        public int Weight { get; set; }
    }
    class Sandwich
    {
        public int Weight { get; set; }
    }

    class MainClass
    {
        public static void Main()
        {
            string[] strs = Console.ReadLine().Split();
            Bread bread = new Bread { Weight = int.Parse(strs[0]) };
            Butter butter = new Butter { Weight = int.Parse(strs[1]) };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);
        }
    }
}