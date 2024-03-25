
int [] CreateRandomArray(int min, int max, int size){
    int [] array = new int [size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int [] array){
    foreach(int item in array){
        Console.Write(item+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите минимальное число в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(min, max, size);
ShowArray(array);