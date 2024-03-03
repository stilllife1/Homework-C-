// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.

int acmann (int m, int n) {
if (m == 0) return n + 1; 
if (m > 0 && n == 0) return acmann (m - 1, 1);
if (m > 0 && n > 0) return acmann(m - 1, acmann(m, n - 1));
else return -1;

}
int result = acmann(3, 2);
System.Console.WriteLine(result);
