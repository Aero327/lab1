using System.Diagnostics;

internal class Program {
    public static void Main(string[] args) {
        Program pr = new Program();

        // Задание 1.2
        /*
        int x1, result1;

        System.Console.Write("Введите число не менее чем с двумя знаками: ");
        x1 = Convert.ToInt32(System.Console.ReadLine());

        result1 = pr.sumLastNums(x1);

        System.Console.WriteLine("Сумма двух последних знаков числа: " + result1);
        */
        // Задание 1.4
        /*
        int x2; 
        bool result2;

        System.Console.Write("Введите число: ");
        x2 = Convert.ToInt32(System.Console.ReadLine());

        result2 = pr.isPositive(x2);
        if (result2) System.Console.WriteLine("Число положительное");
        else System.Console.WriteLine("Число не положительное");
        */
        // Задание 1.6
        /*
        char x3; 
        bool result3;

        System.Console.Write("Введите символ: ");
        x3 = Convert.ToChar(System.Console.ReadLine());

        result3 = pr.isUpperCase(x3);
        if (result3) System.Console.WriteLine("Символ является прописной буквой");
        else System.Console.WriteLine("Символ не является прописной буквой");
        */
        // Задание 1.8
        int a4, b4;
        bool result;

        System.Console.Write("Введите число a: ");
        a4 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Введите число b: ");
        b4 = Convert.ToInt32(Console.ReadLine());

        if ((a4 == 0 || b4 == 0) && !(a4 == 0 && b4 == 0)) 
            System.Console.WriteLine("Одно из чисел делит другое нацело");

        else if (a4 == 0 && b4 == 0)
            System.Console.WriteLine("Ошибка: деление на 0");

        else {
            result = pr.isDivisor(a4, b4);
            if (result) System.Console.WriteLine("Одно из чисел делит другое нацело");
            else System.Console.WriteLine("Ни одно из чисел не делит другое нацело");
        }

    }

    // Задание 1.2
    public int sumLastNums(int x) {
        string num = x.ToString();

        return (num[num.Length - 1] - '0') + (num[num.Length - 2] - '0');
    }

    // Задание 1.4
    public bool isPositive(int x) {
        return x > 0;
    }

    // Задание 1.6
    public bool isUpperCase(char x) {
        return char.IsUpper(x);
    }

    // Задание 1.8
    public bool isDivisor(int a, int b) {
        return a % b == 0 || b % a == 0;
    }
}