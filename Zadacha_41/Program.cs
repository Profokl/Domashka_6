// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

#nullable disable
Console.WriteLine("Введите числа через запятую:");

string numbers = Console.ReadLine();
string[] arrayNumbers = numbers.Split(',');

int[] GetArray(string[] tmp)
{
    int len = tmp.Length;
    int[] newArray = new int[len];
    int i = 0;
    for (i = 0; i < len; i++)
    {
        newArray[i] = Convert.ToInt32(tmp[i].ToString());
    }
    return newArray;
}

int AboveZero(int[] anyArray)
{
    int count = 0;
    for (int i = 0; i < anyArray.Length; i++)
    {
        if (anyArray[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = GetArray(arrayNumbers);
int count = AboveZero(array);
Console.WriteLine($"Количество чисел больше нуля: {count}");


