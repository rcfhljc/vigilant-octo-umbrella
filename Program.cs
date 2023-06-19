// ЗАДАЧА 10
// int number = ReadInt("Введите трехзначное число: ");
// int amount = number.ToString().Length;
// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int InCenter(int a)
// {

//     int result = ((a / 10) % 10);
//     return result;
// }




// ЗАДАЧА 13
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int MakeArray(int a, int b)
// {
//     int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
//     return result;
// }

// ЗАДАЧА 15
// int Prompt(string msg)
// {
//     Console.WriteLine($"{msg}");
//     return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите число");
// string ss = ("Это не день недели");
// string check(int number)
// {
//     if (number >= 6 && number < 8) ss = ("Это выходной");
//     if (number >= 1 && number < 7) ss = ("Это будний день");
//     return ss;
// }
// Console.WriteLine(check(number));