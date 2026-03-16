int[] array = { 5, 2, 8, 1, 9, 3 };
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine(max);
// хых