// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] CreateArray (int size) //Данная функция создает массив
{
    int[] createArray = new int[size];
    return createArray;
}
void FillArrayRandomNumbers (int[] array) //Функция заполняет массив случайными числами от 1 до 999
{
    Random rnd = new Random();

    for(int i=0; i<array.Length; i++)
        array[i] = rnd.Next(-100,100);
}
string GetArrayInString(int[] array) // Созданный массив записывается в ввиде строки
{
    return String.Join(", ", array);
}
void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int NewArray(int[] array)
{
    int count = 0;

    for (int i = 0; i<array.Length; i++)
    {
       if(array[i] > 0)
            count++;
    }
    return count;    
}

int size = 5;

int[] array = CreateArray(size);
FillArrayRandomNumbers(array);
GetArrayInString(array);
PrintArray(array);

System.Console.WriteLine(NewArray(array));
