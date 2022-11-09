// зададим массив из пяти элементов, которые пользователь введет с клавиатуры

string[] array = new string[5];

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите что-то: ");
    array[i] = Convert.ToString(Console.ReadLine()!);
}

string[] resultArray = new string[array.Length];
int k = 0;

for(int j = 0; j < array.Length; j ++)
{
    if(array[j].Length < 4)
    {
        resultArray[k] = array[j];
        k++; 
    }
    
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Ниже представлены элементы,  длина которыч меньше или равна 3");
PrintArray(resultArray);