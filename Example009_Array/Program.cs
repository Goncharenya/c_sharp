
int[] array = {11, 12, 14, 22, 3, 9, 7, 43, 12, 18};

int n = array.Length;
int find = 12;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}


