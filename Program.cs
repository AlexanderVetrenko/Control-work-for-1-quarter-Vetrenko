/* Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на
старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами. */

string a, b, c, d, e;

Input(out a, out b, out c, out d, out e);
string[] matrix = {a, b, c, d, e};
PrintArray(ShortMassiv(matrix));
/*FillArray(matrix, x, y);
System.Console.WriteLine();
PrintArray(matrix, x, y); */

void Input(out string a1, out string a2, out string a3, out string a4, out string a5)
{
    System.Console.WriteLine("Наполните маасив данными. Необходимо ввести пять любых слов (необязательно осмысленных), после ввода каждого нажимайте Enter:");
    a1 = Console.ReadLine();
    a2 = Console.ReadLine();
    a3 = Console.ReadLine();
    a4 = Console.ReadLine();
    a5 = Console.ReadLine();
}

string[] ShortMassiv(string[] arr)
{
    int k = 0, j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) k += 1;
    }
    string[] matr = new string[k];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            matr[j] = arr[i];
            j += 1;
        }
    }
    return matr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i],3} |");
    }
}

/*void FillArray(int[,] arr, int a, int b)

{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
} */

