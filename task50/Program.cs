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

int[] RequestIndex(){
    int[] arr = new int[2];
    arr[0] = int.Parse(Console.ReadLine());
    arr[1] = int.Parse(Console.ReadLine());
    
    return arr;
}

void CheckIndex(){
    int[,] arr = RequestNumsInArr();
    int[] index = RequestIndex();
            
    if(index[0]>0 && index[0]<arr.GetLength(0)){
        if(index[1]>0 && index[1]<arr.GetLength(1)){
            Console.WriteLine(arr[index[0], index[1]]);
        }else{
            Console.WriteLine("такого числа в массиве нет");
        }
    }else{
        Console.WriteLine("такого числа в массиве нет");
    }
}

CheckIndex();










