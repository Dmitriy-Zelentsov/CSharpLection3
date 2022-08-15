//ОТСОРТИРУЙТЕ МАССИВ:
// 1. Найти позицию минимального элемента
//в неотсортированной части массива
//2. Произвести обмен этого значения со
//значением первой неотсортированной позиции
//3. Повторять пока есть не отсортированные элементы

int [] array = {1, 2, 7, 6, 2, 98, 5, 34, 0};
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
void SelectionSort(int [] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
       int minPosition = i;
        for (int j = i + 1; j < array.Length; j++ )
        {
            if (array[j] < array [minPosition]) minPosition = j;
        }
       int temp = array [i];
       array[i] = array[minPosition];
       array [minPosition]= temp;
       Console.Write($"{array[i]}, ");
    }
}
PrintArray(array);
Console.WriteLine ();
SelectionSort(array);
