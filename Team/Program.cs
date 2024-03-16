using static System.Console;
using static System.Convert;
using static System.Math;

int n, counter1, counter2 = 0;
int[,] arr1 = new int[1000, 3];
n = ToInt32(ReadLine());
for (int i = 0; i < n; i++)
{
    string str = ReadLine();
    var arr2 = str.Split(" ");
    arr1[i, 0] = ToInt32(arr2[0]);
    arr1[i, 1] = ToInt32(arr2[1]);
    arr1[i, 2] = ToInt32(arr2[2]);
    counter1 = 0;
    for (int j = 0; j < 3; j++)
    {

        if (arr1[i, j] == 1)
        {
            counter1++;
        }
    }
    if (counter1 >= 2)
    {
        counter2++;
    }
}

WriteLine(counter2);

