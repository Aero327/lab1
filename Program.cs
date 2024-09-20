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
        int x2; 
        bool result2;

        System.Console.Write("Введите число: ");
        x2 = Convert.ToInt32(System.Console.ReadLine());

        result2 = pr.isPositive(x2);
        if (result2) System.Console.WriteLine("Число положительное");
        else System.Console.WriteLine("Число не положительное");
    }

    // Задание 1.2
    public int sumLastNums(int x) {
        string num = x.ToString();

        return (num[num.Length - 1] - '0') + (num[num.Length - 2] - '0');
    }

    public bool isPositive(int x) {
        return x > 0;
    }
}