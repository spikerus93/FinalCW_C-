// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] array  = new string [m];

MyArray(array);
PrintArray(GenerateMyArray(array));

void MyArray(string? [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Console.ReadLine();
    }
}

string [] GenerateMyArray(string [] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        n++;
    }
    string [] strings= new string [n];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            strings[count] = array[i];
            count++;
        }
    }
    return strings;   
}

void PrintArray(string [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

