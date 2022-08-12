// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Функция описывающая заполнение массива
double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100 + 1);
    }
    return result;
}

//Просим пользователя ввести колличество элементов массива
Console.WriteLine("\nВведите колличество элементов массива, состоящего из чисел от -100 до 100");
int size = Int32.Parse(Console.ReadLine());

//Заполняем массив
double[] array = GetArray(size);

//Объявляем переменную-счетчик, которая будет подсчитывать результат задачи
int count = 0;

//Алгоритм для нахождения результата условий задачи
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

//Вывод результата
Console.WriteLine($"\n[{String.Join(", ", array)}]\n" +
                    $"\nКолличество чисел в массиве, которые больше нуля = {count}\n");

