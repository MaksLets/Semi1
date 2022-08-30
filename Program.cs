// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
// например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

//Console.Write("введите число: ");// 1. Прилашение к вводу 
//int number - Convert.ToInt32(Console.ReadLine()); // 2. Считывание данных с консоли и преобразование в тип int
//string? str = Console.ReadLine(); // 2.1 Считываем данные с консоли 
//int number = Convert.ToInt32(str); // 2.2 Конвертация в число 
//Console.Write(number*number); // 3. Вывод на экран number ^ 2

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго 
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

//int a = 25;
//int b = 5;

//if(a == b * b) {
//    Console.Write(" Да ");
//}
//else {
//    Console.Write("Нет");
//}
//
 //Console.Write("Введите первое число");
 //int number1 = Convert.ToInt32(Console.ReadLine());
 // Console.Write("Введите второе число");
 //  int number2 = Convert.ToInt32(Console.ReadLine());
//if(number1 == number2 * number2) {
//    Console.Write("yes")
//}
//else{
//    Console.Write("no")
//}

Console.Write("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 & number >= 1) {
    if(number == 1) {
        Console.WriteLine("понедельник");
    }
    if(number == 2) {
        Console.WriteLine("вторник");
    }
    if(number == 3) {
        Console.WriteLine("среда");
    }
    if(number == 4) {
        Console.WriteLine("четверг");
    }
    if(number == 5) {
        Console.WriteLine("пятница");
    }
    if(number == 6) {
        Console.WriteLine("суббота");
    }
    if(number == 7) {
        Console.WriteLine("воскресенье");
    }
}
else {
    Console.WriteLine("Такого дня недели не существует");
}





