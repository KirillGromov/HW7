
int[] RequestSize(){
    Console.WriteLine("Введите размерность массива m n");
    int m = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    int[] arr = {m, n};
    return arr;
}

void RequestNumsInArr(int[] arr){

    Random ran = new Random();

    int[,] arra = new int[arr[0], arr[1]];
    for(int i = 0; i<arr[0]; i++){
        for(int j = 0; j<arr[1]; j++){
            arra[i, j] = ran.Next(-10, 10);
        }
    }

    ShowArr(arra);
}

void ShowArr(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(" " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

RequestNumsInArr(RequestSize());
