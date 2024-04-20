int N = 5;
int[] arr = {16, 3, 9, 2, 1};
int i = 0;
int max = arr[i];

while (i < arr.Length)
{
    if(arr[i] > max)
    {
    max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = arr[0];
for(int j = 0; j < arr.Length; j++)
{
    if(arr[j] > max)
    {
    max = arr[j];
    }
}
Console.WriteLine(max);

max = arr[0];
foreach(int e in arr)
{
    if(e > max)
    {
    max = e;
    }
}
Console.WriteLine(max);