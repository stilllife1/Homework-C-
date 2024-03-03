// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



void Main(){
System.Console.Write("Введите первое число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int M = Convert.ToInt32(Console.ReadLine());
countNumbers(N, M);
}
Main();
int countNumbers(int number1, int number2) { 
  if (number2 < number1) return 0;
    System.Console.Write($"{number1} ");
return countNumbers(number1 + 1, number2);
  }