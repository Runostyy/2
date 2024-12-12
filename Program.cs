using System;

class Program
{
    static void Main()
    {
        // Оголошуємо лямбда-вираз для обчислення суми квадратів двох чисел
        Func<int, int, int> sumOfSquares = (a, b) => (a * a) + (b * b);

        // Введення двох чисел
        Console.WriteLine("Введіть перше число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Викликаємо лямбда-вираз та виводимо результат
        int result = sumOfSquares(num1, num2);
        Console.WriteLine($"Сума квадратів чисел {num1} і {num2} дорівнює: {result}");
    }
}
