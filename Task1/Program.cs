//int[] arr = new int[5];
//arr[0] = 5;
//arr[1] = 3;
//arr[2] = 1;
//arr[3] = 7;
//arr[4] = 9;
//Console.WriteLine(arr[0]);
//Console.WriteLine(arr[1]);
//Console.WriteLine(arr[2]);
//Console.WriteLine(arr[3]);
//Console.WriteLine(arr[4]);

//int[] arr2 = new int[5] { 0, 3, 5, 7, 9 };

//int[] arr3 = { 1, 2, 3, 4, 5 };

//Console.WriteLine("Input size of Arrow");
//Console.ConvertToInt32

int N = 10;
int[] arr = new int[N];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.WriteLine(arr[i]);
    //Console.WriteLine(" ");
    Console.Write($"{arr[i]} ");
    i = i + 1;
}