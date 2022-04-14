void FillArray(int[] collection) //оператор void - не возвращает значения 
//(тогда не нужен оператор return)
{ // первый метод
    int length = collection.Length; // длинна массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // положим сюда число из позиции 1, 10
        //index = index + 1;
        index++;
    }
}
void PrintArray(int[] col) // метод void который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// используем метод возвращения массива
int indexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если элемента нет, то договорились указывать -1 (минус один)
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;  //чтобы вывести не последнее значение 4, а первое добавляем этот оператор
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // оператор заполнения массива
// искусственно создадим 4 на 4 позицию и 6
array[4] = 4;
array[6] = 4;

PrintArray(array); // оператов вывода на печать массива
// метод заполнения массива
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);
