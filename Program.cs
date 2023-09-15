// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = new string[6] { "hello", "world", "1", "17", "tru", "vr" };
int n = array.Length;
string[] checkArray = new string[n];

void FillArray(string[] array, string[] checkArray)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i].Length < 3)
        {
            checkArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length ; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(array);
Console.WriteLine();
FillArray(array, checkArray);
PrintArray(checkArray);