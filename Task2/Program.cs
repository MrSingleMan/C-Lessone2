int N = 10;
int[] arr = {1, 3, 5, 7, 2, 3, 9, 0, 5, 2};
int i = 0;

while (i < arr.Length)
{
    if(arr[i] % 2 == 0)
    {
    Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}