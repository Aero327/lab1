internal class Program {
    public static void Main(string[] args) 
    {
        Program pr = new Program();
        int taskNum = 0, varNum = 0;

        try 
        {
            Console.Write("Введите номер задания: ");
            taskNum = Convert.ToInt32(Console.ReadLine());

            if (taskNum > 0 && taskNum < 5) 
            {
                Console.Write("Введите вариант задания: ");
                varNum = Convert.ToInt32(Console.ReadLine());

                switch (taskNum) 
                {
                    case 1:
                        pr.chooseTask1(pr, varNum);
                        break;
                    case 2:
                        pr.chooseTask2(pr, varNum);
                        break;
                    case 3:
                        pr.chooseTask3(pr, varNum);
                        break;
                    case 4:
                        pr.chooseTask4(pr, varNum);
                        break;
                }
            }
            else Console.WriteLine("Ошибка при обработке номера задания. Возможно вы ввели неверный номер");
        }
        catch (Exception ex) 
        {
            switch (ex) 
            {
                case System.FormatException:
                    Console.WriteLine("Ошбика: неправильный ввод");
                    break;
                default:
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                    break;
            }
            return;
        }
    }

    public void chooseTask1(Program pr, int varNum) 
    {
        try
        {
            switch (varNum) 
            {
                case 2: 
                    pr.task1_2(pr);
                    break;
                case 4:
                    pr.task1_4(pr);
                    break;
                case 6:
                    pr.task1_6(pr);
                    break;
                case 8:
                    pr.task1_8(pr);
                    break;
                case 10:
                    pr.task1_10(pr);
                    break;
                default:
                    Console.WriteLine("Ошибка при обработке номера варианта. Возможно вы ввели неверный номер");
                    break;
            }
        }
        catch (Exception ex) 
        {
            switch (ex) 
            {
                case System.FormatException:
                    Console.WriteLine("Ошбика: неправильный ввод");
                    break;
                default:
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                    break;
            }
            return;
        }
    }

    public void chooseTask2(Program pr, int varNum) 
    {
        try
        {
            switch (varNum) 
            {
                case 2: 
                    pr.task2_2(pr);
                    break;
                case 4:
                    pr.task2_4(pr);
                    break;
                case 6:
                    pr.task2_6(pr);
                    break;
                case 8:
                    pr.task2_8(pr);
                    break;
                case 10:
                    pr.task2_10(pr);
                    break;
                default:
                    Console.WriteLine("Ошибка при обработке номера варианта. Возможно вы ввели неверный номер");
                    break;
            }
        }
        catch (Exception ex) 
        {
            switch (ex) 
            {
                case System.FormatException:
                    Console.WriteLine("Ошбика: неправильный ввод");
                    break;
                default:
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                    break;
            }
            return;
        }
    }

    public void chooseTask3(Program pr, int varNum) 
    {
        try
        {
            switch (varNum) 
            {
                case 2: 
                    pr.task3_2(pr);
                    break;
                case 4:
                    pr.task3_4(pr);
                    break;
                case 6:
                    pr.task3_6(pr);
                    break;
                case 8:
                    pr.task3_8(pr);
                    break;
                case 10:
                    pr.task3_10(pr);
                    break;
                default:
                    Console.WriteLine("Ошибка при обработке номера варианта. Возможно вы ввели неверный номер");
                    break;
            }
        }
        catch (Exception ex) 
        {
            switch (ex) 
            {
                case System.FormatException:
                    Console.WriteLine("Ошбика: неправильный ввод");
                    break;
                default:
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                    break;
            }
            return;
        }
    }

    public void chooseTask4(Program pr, int varNum) 
    {
        try
        {
            switch (varNum) 
            {
                case 2: 
                    pr.task4_2(pr);
                    break;
                case 4:
                    pr.task4_4(pr);
                    break;
                case 6:
                    pr.task4_6(pr);
                    break;
                case 8:
                    pr.task4_8(pr);
                    break;
                case 10:
                    pr.task4_10(pr);
                    break;
                default:
                    Console.WriteLine("Ошибка при обработке номера варианта. Возможно вы ввели неверный номер");
                    break;
            }
        }
        catch (Exception ex) 
        {
            switch (ex) 
            {
                case System.FormatException:
                    Console.WriteLine("Ошбика: неправильный ввод");
                    break;
                default:
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                    break;
            }
            return;
        }
    }

    // Задание 1.2
    public void task1_2(Program pr) 
    {
        int x, result1;

        System.Console.Write("Введите число не менее чем с двумя знаками: ");
        x = Convert.ToInt32(System.Console.ReadLine());

        result1 = pr.sumLastNums(x);

        System.Console.WriteLine("Сумма двух последних знаков числа: " + result1);
    }

    public int sumLastNums(int x) 
    {
        string num = x.ToString();

        return num[^1] - '0' + num[^2] - '0';
    }

    // Задание 1.4
    public void task1_4(Program pr) 
    {
        int x; 
        bool result2;

        System.Console.Write("Введите число: ");
        x = Convert.ToInt32(System.Console.ReadLine());

        result2 = pr.isPositive(x);
        if (result2) System.Console.WriteLine("Число положительное");
        else System.Console.WriteLine("Число не положительное");
    }

    public bool isPositive(int x) 
    {
        return x > 0;
    }

    // Задание 1.6
    public void task1_6(Program pr) 
    {
        char x; 
        bool result;

        System.Console.Write("Введите символ: ");
        x = Convert.ToChar(Console.ReadLine());

        result = pr.isUpperCase(x);

        if (result) 
            System.Console.WriteLine("Символ является прописной буквой");
        else 
            System.Console.WriteLine("Символ не является прописной буквой");
    }

    public bool isUpperCase(char x) 
    {
        return char.IsUpper(x);
    }

    // Задание 1.8
    public void task1_8(Program pr) 
    {
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

    public bool isDivisor(int a, int b) 
    {
        return a % b == 0 || b % a == 0;
    }

    // Задание 1.10
    public void task1_10(Program pr) 
    {
        int a, b;
        Random rand = new Random();

        a = rand.Next(0, 100);
        for (int i = 0; i < 5; i++) {
            b = rand.Next(0, 100);
            Console.Write(a + "+" + b + " это ");
            
            a = pr.lastNumSum(a, b);
            Console.WriteLine(a);
        }

        Console.WriteLine("Итого " + a);

    }
    
    public int lastNumSum(int a, int b) 
    {
        return a % 10 + b % 10;
    }
    
    // Задание 2.2
    public void task2_2(Program pr) {
        int x, y; 
        double result;
        
        Console.Write("Введите x: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите y: ");
        y = Convert.ToInt32(Console.ReadLine());

        result = pr.safeDiv(x, y);
        Console.WriteLine("Результат: " + result);
    }

    public double safeDiv(int x, int y) 
    {
        if (y == 0) return 0;
        return (double)x / y;
    }
    
    // Задание 2.4
    public void task2_4(Program pr) 
    {
        int x, y; 
        string result;
        
        Console.Write("Введите x: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите y: ");
        y = Convert.ToInt32(Console.ReadLine());

        result = pr.makeDecision(x, y);
        Console.WriteLine("Результат: " + result);
    }

    public string makeDecision(int x, int y)
    {
        if (x > y) return $"{x}>{y}";
        else if (x < y) return $"{x}<{y}";
        return $"{x}=={y}";
    }
    
    // Задание 2.6
    public void task2_6(Program pr) 
    {
        int x, y, z;
        
        Console.Write("Введите x: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите y: ");
        y = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите z: ");
        z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Результат: " + pr.sum3(x, y, z));
    }

    public bool sum3(int x, int y, int z)
    {
        return x + y == z || x + z == y || y + z == x;
    }
    
    // Задание 2.8
    public void task2_8(Program pr) {
        int x;

        Console.Write("Введите возраст: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(pr.age(x));
    }

    public String age(int x)
    {
        if (x % 10 == 1 && x != 11) return x + " год";
        else if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && x != 12 && x != 13 && x != 14)
            return x + " года";
        return x + " лет";
    }
    
    // Задание 2.10
    public void task2_10(Program pr) 
    {
        String x;

        Console.Write("Введите день недели: ");
        x = Console.ReadLine();

        pr.printDays(x);
    }

    public void printDays(String x)
    {
        string[] days = new string[7] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine(string.Join("\n", days));
                return;
            case "вторник":
                Console.WriteLine(string.Join("\n", days[1..]));
                return;
            case "среда":
                Console.WriteLine(string.Join("\n", days[2..]));
                return;
            case "четверг":
                Console.WriteLine(string.Join("\n", days[3..]));
                return;
            case "пятница":
                Console.WriteLine(string.Join("\n", days[4..]));
                return;
            case "суббота":
                Console.WriteLine(string.Join("\n", days[5..]));
                return;
            case "воскресенье":
                Console.WriteLine(days[^1]);
                return;
            default:
                Console.WriteLine("Это не день недели");
                return;
        }
    }

    // Задание 3.2
    public void task3_2(Program pr) 
    {
        int x;

        Console.Write("Введите число: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Результат: " + pr.reverseListNums(x));
    }

    public String reverseListNums(int x)
    {
        String num = "";
        
        for (int i = x; i >= 0; i--)
            num += i + " ";
        
        return num.Trim();
    }
    
    // Задание 3.4
    public void task3_4(Program pr) 
    {
        int x, y;
        
        Console.Write("Введите число: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите степень: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Число {x} в степени {y} -> {pr.pow(x, y)}");
    }

    public int pow(int x, int y)
    {
        int result = 1;

        for (int i = 0; i < y; i++)
            result *= x;
        
        return result;
    }
    
    // Задание 3.6
    public void task3_6(Program pr) 
    {
        int x;
        bool result;
        
        Console.Write("Введите число: ");
        x = Convert.ToInt32(Console.ReadLine());

        result = pr.equalNum(x);
        
        if (result) Console.WriteLine("В этом числе все цифры одинаковы");
        else Console.WriteLine("В этом числе цифры различаются");
    }

    public bool equalNum(int x)
    {
        int last_digit, n = x.ToString().Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            last_digit = x % 10;
            x = x / 10;
            
            if (x % 10 != last_digit) return false;
        }
        
        return true;
    }
    
    // Задание 3.8
    public void task3_8(Program pr) 
    {
        int x;
        
        Console.Write("Введите число: ");
        x = Convert.ToInt32(Console.ReadLine());
        
        pr.leftTriangle(x);
    }

    public void leftTriangle(int x)
    {
        for (int i = 1; i < x + 1; i++)
        {
            for (int j = 1; j < i + 1; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }
    
    // Задание 3.10
    public void task3_10(Program pr) 
    {
        pr.guessGame();
    }

    public void guessGame()
    {
        int user_guess, user_guess_count = 1;
        
        Random rand = new Random();
        int guessed_num = rand.Next(0, 9);

        Console.Write("Введите число от 0 до 9: ");
        user_guess = Convert.ToInt32(Console.ReadLine());
        
        while (user_guess != guessed_num)
        {
            user_guess_count += 1;
            
            Console.Write("Вы не угадали, введите число от 0 до 9: ");
            user_guess = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Вы угадали!");
        Console.WriteLine($"Вы отгадали число за {user_guess_count} попытки");
    }
    
    // Задание 4.2
    public void task4_2(Program pr) 
    {
        int x, n, result;
        
        Console.Write("Введите длину массива: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Введите искомое число: ");
        x = Convert.ToInt32(Console.ReadLine());

        result = pr.findLast(arr, x);
        if (result < 0) 
            Console.WriteLine("Число не найдено");
        else 
            Console.WriteLine($"Индекс искомого числа в массиве: {result}");
    }

    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }

    // Задание 4.4
    public void task4_4(Program pr) 
    {
        int x, n, pos;
        
        Console.Write("Введите длину массива: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[n];
        int[] result = new int[n + 1];
        
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Введите число, которое хотите добавить: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите индекс, на место которого вы хотите вставить число: ");
        pos = Convert.ToInt32(Console.ReadLine());
        
        result = pr.add(arr, x, pos);
        string str = "[" + string.Join(", ", result) + "]";
        Console.Write($"Итоговый массив: {str}");
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] result = new int[arr.Length + 1];
        result[pos] = x;
        bool flag = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (flag)
                result[i + 1] = arr[i];
            else if (i != pos)
                result[i] = arr[i];
            else
            {
                i -= 1;
                flag = true;
            }
        }

        return result;
    }

    // Задание 4.6
    public void task4_6(Program pr) 
    {
        int n;

        Console.Write("Введите длину массива: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        pr.reverse(ref arr);
        Console.WriteLine($"Ваш массив наоборот: [{string.Join(", ", arr)}]");
    }

    public void reverse(ref int[] arr)
    {
        int[] arrCopy = new int[arr.Length];
        arr.CopyTo(arrCopy, 0);

        for (int i = 0; i < arr.Length; i++)
            arr[i] = arrCopy[arr.Length - 1 - i];
    }
    
    // Задание 4.8
    public void task4_8(Program pr) 
    {
        int n1, n2;

        Console.Write("Введите длину первого массива: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n1];

        Console.WriteLine("Введите элементы первого массива:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Введите длину второго массива: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[n2];

        Console.WriteLine("Введите элементы второго массива:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        int[] result = new int[n1 + n2];
        result = pr.concat(arr1, arr2);

        Console.WriteLine($"Результат слияния массивов: [{string.Join(", ", result)}]");
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
            result[i] = arr1[i];
        for (int i = 0; i < arr2.Length; i++)
            result[i + arr1.Length] = arr2[i];
        
        return result;
    }
    
    // Задание 4.10
    public void task4_10(Program pr) 
    {
        int n;

        Console.Write("Введите длину массива: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Массив без отрицательных чисел: [{string.Join(", ", pr.deleteNegative(arr))}]");
    }

    public int[] deleteNegative(int[] arr)
    {
        int[] result = new int[arr.Length];
        int positiveCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[positiveCount] = arr[i];
                positiveCount++;
            }
        }
        
        return result[0..positiveCount];
    }
}