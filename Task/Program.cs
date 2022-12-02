//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = new string [4] {"Вий", "Яма", "На дне", "Мцыри"};
string[] find = new string [array.Length];

void FindThreeDigitString(string[] array, string[] find)
{
    int size = 3;
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= size)
        {
            find[j] = array[i];
            j++;
        }

    }

}
void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ShowArray(array);
FindThreeDigitString(array,find);
Console.WriteLine();
ShowArray(find);
