int[] arr1= {1,2,3,4,5,6,7,8,9,11};
int i=0;
while (i < arr1.Length)
{
    if (arr1[i]%2==0)
    {
        Console.Write($"{arr1[i]} ");
    }
    i=i+1;
}