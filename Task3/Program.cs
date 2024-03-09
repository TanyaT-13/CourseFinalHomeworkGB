//  Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//  Использовать рекурсию, не использовать циклы.

void ShowArrayReverse(int[] array, int i){
    if (i < 0 || i > array.Length - 1){
        return;
    }

    ShowArrayReverse(array, i + 1);
    Console.Write($"{array[i]} ");
}

int[] array = { 1, 2, 5, 7, 18 };
ShowArrayReverse(array, 0);