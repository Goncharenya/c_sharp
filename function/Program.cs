int ResultMax (int arg1, int arg2, int arg3) 
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
};

int a1 = 21;
int b1 = 3122;
int c1 = 11;

int a2 = 41;
int b2 = 51;
int c2 = 2;

int a3 = 1;
int b3 = c1+a2;
int c3 = 7779;

// int max1 = ResultMax(a1, b1, c1);
// int max2 = ResultMax(a2, b2, c2);
// int max3 = ResultMax(a3, b3, c3);
int max = ResultMax(ResultMax(a1, b1, c1), 
        ResultMax(a2, b2, c2), 
        ResultMax(a3, b3, c3));


Console.WriteLine(max);