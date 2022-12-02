int[] array = { 12, 44, 86, 77, 99, 68, 43, 64, 86 };

int n = array.Length;
int find = 86;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index=index+1
    index++;
}