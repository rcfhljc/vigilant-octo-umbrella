
//2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");

//3.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (max < b) max = b;
// if (max < c) max = c;
// Console.WriteLine("Максимальное из этих чисел ="+max );

//6.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// Console.WriteLine("Четное");
// else Console.WriteLine("Нечетное");

//8.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// for(int index= 1; index <= n; index++)
// if (index % 2 == 0)
// Console.Write(index + ", ");