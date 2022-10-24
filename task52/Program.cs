int[,] RequestNumsInArr(){

    Random ran = new Random();
    Console.WriteLine("Введите размерность массива");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int[,] arr = new int[a, b];
    for(int i = 0; i<a; i++){
        for(int j = 0; j<b; j++){
            arr[i, j] = ran.Next(1, 10);
        }
    }
    ShowArr(arr);
    return arr;
}

void ShowArr(int[,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            Console.Write(" " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

void Average(int[,] arr){
    int j = 0;
    double[] summArr = new double[arr.GetLength(1)];

    for(int i = 0; i<arr.GetLength(1); i++){
        summArr[i] = (double)Summa(i, arr)/arr.GetLength(0);
        Console.Write(summArr[i] + " ");
    }
 
}

int Summa(int j, int[,] arr){
    int sum = 0;
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int m = j; m<arr.GetLength(1); m++){
            if(m==j){
                sum+=arr[i,m];
                
            }else{
                continue;
            }
        }
    }
    return sum;
}

Average(RequestNumsInArr());
