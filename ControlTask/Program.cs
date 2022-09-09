void ControlTask()
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int sizeResult = 0;

    if (size > 0)
    {
        string[] array = new string[size];
        string[] arrayResult = new string[sizeResult];
        Console.WriteLine("Введите элементы массива, разделяя их клавишей Enter");
        FillArray(array);
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        arrayResult = FillArrayLengthCondition(array, arrayResult, 3);
        Console.WriteLine("Результирующий массив:");
        PrintArray(arrayResult);
    }
    else Console.WriteLine("Размерность массива должна быть больше нуля!");
}

//Заполнение массива строк вводом с клавиатуры
void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

//Печать массива строк
void PrintArray(string[] arr)
{
    int size = arr.Length;
    if (size == 0)
        Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for (int i = 0; i < size; i++)
        {
            Console.Write("'" + arr[i] + "', ");
        }
        Console.WriteLine("\b\b" + "]");
    }
}

//Заполнение нового массива строками, длина которых меньше, либо равна
//заданному количеству
string[] FillArrayLengthCondition(string[] arr, string[] arrResult, int lengthCond)
{
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= lengthCond)
        {
            Array.Resize(ref arrResult, index + 1);
            arrResult[index] = arr[i];
            index++;
        }
    }
    return arrResult;
}

ControlTask();