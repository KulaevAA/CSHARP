int[] arr1 = {1,2,7,3,4,5};
int max = arr1[0];
int i =0;
while ( i < arr1. Length)
{
    if (arr1[i]>max)
    {
        max =arr1[i];
    }
    i=i+1;
}
Console.WriteLine(max);

max=arr1[0];
for (int j=0; j<arr1.Length; j++)
{
 if (arr1[j]>max)
    {
        max =arr1[j];
    }   
}
Console.WriteLine(max);

max=arr1[0];
foreach ( int e in arr1)
{
    if ( e > max)
    {
        max=e;
    }
}
Console.WriteLine(max);