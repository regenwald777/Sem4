
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

int CountofPrimes(int [] array){
    int count = 0;
    foreach(int el in array){
            if(IsPrime(el)){
                count++;
            }
    }
    return count;
}

bool IsPrime(int num){
        double limit = Math.Sqrt(num);
        for(int i = 2; i <= limit;i++){
            if(num%i==0){
                return false;
            }
            
        }
        return true;
}

Console.WriteLine("Введите минимальное число в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число в массиве");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

//задать массив заполненный случайными числами и определить количество простых чисел в массиве.
//Примеры
//[1 3 4 19 3] =>2
//[4 3 4 1 9 5 21 13] =>3


int [] array = CreateRandomArray(min, max, size);
ShowArray(array);
int count = CountofPrimes(array);
Console.WriteLine($"Количество простых чисел в массиве равно - {count}");