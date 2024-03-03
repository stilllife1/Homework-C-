// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void Main()
{

  System.Console.Write("Введите длину массива: ");
  int arrLenght = Convert.ToInt32(Console.ReadLine());

  int[] array = new int[arrLenght];
  createArray(array);
  printArray(array);
  System.Console.WriteLine();
  reverseArray(array, arrLenght - 1);
} Main();

void createArray(int[] arr) {
  for (int i = 0; i < arr.Length; i++)
  {
    Random random = new Random();
    arr[i] = random.Next(1, 10);
  }
}
void printArray(int[] arr) {
  for (int i = 0; i < arr.Length; i++)
  {
    System.Console.Write(arr[i] + " ");
  }
}

void reverseArray(int[] arr, int index) {
  if (index < 0) return;
  System.Console.Write(arr[index] + " ");
  reverseArray(arr, index - 1);
}
