﻿/* /Итак, вы попробовали создавать методы для работы с текстом. Теперь снова поработаем с
массивами. В качестве задачи для работы с массивами, я выбрал упорядочивание данных
внутри массива. Существуют разные алгоритмы, которые вы, скорее всего, будете писать в
дальнейшем. Остановимся на одном из самых простых. Это так называемый алгоритм
сортировки методом выбора, ещё его называют алгоритм сортировки методом минимакса или
иногда просто называют методом максимального, или выбора максимального или выбора
минимального и так далее. Узнаем, в чём особенность (суть) этого алгоритма. Есть какая-то
последовательность чисел. Наша задача — выбрать самый первый элемент и в оставшейся
части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, это
6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.
Было: 6 8 3 2 1 4 5 7
Стало: 1 8 3 2 6 4 5 7 */
Console.Clear();

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        {
        Console.Write($"{array[i]}");
        }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
    {
    int minPosition = i;
    for (int j = i+1; j < array.Length; j++)
        {
        if(array[j] < array[minPosition]) //minPosition = j;
        {
        minPosition = j;
        }
        }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    }
}
PtintArray(arr);
selectionSort(arr);
PtintArray(arr);