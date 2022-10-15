// int[] a = {12, 242, 512, 53, 52, 632, 254, 242, 234};
// int n = a.Length;
// int find = 234;

// int index= 0;
// while(index < n)
// {
//     if(a[index] == find)
//     {
//         Console.WriteLine(index);
//     }
//     index++;
// }
void r(int[] col)
{
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(1, 10);
        index++;
    }
}
void p(int[] col2)
{
    int count = col2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col2[position]);
        position++;
    }


}

int I(int[] col, int find)
{
    int count = col.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
     if (col[index] == find)
     {
        position = index;
        break;
     }
     index++;   
    }
    return position;
}

int[] m = new int[15];
r(m);
p(m);
Console.WriteLine();

int pos = I(m, 4);
Console.WriteLine(pos);