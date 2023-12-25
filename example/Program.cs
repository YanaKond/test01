// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите колличество строк:");
int n = int.Parse(Console.ReadLine());
string [] array = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    array[i] = Console.ReadLine();
}
Console.Write("Первоначальный массив: ");
Console.WriteLine(string.Join(", ", array));

int count = 0;
foreach (string s in array)
{
    if (s.Length <= 3)
    {
        count++;
    }
}
