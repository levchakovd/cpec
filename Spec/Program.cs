Console.WriteLine("Сколько элементов будет в первом массиве?");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
string[] array2 = new string[array1.Length];

void FillArray(string[] array1)
{
    for (int i = 0; i < array1.Length;i++)
    {
        Console.WriteLine("Введите " + (i+1) + " элемент массива");
        array1[i] = Console.ReadLine();
       
    }
}

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

FillArray(array1);
SecondArray(array1,array2);
PrintArray(array2);