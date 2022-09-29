using System.Runtime.CompilerServices;

int a = 100;
double b = a;//implicit type  conversion
int c = 100;
byte = (byte)c;//explicit conversion

//if else
int d = 10;
if (d >=10)
{
    Console.WriteLine("value greater or 10");
}
else
{
    Console.WriteLine("value less than 10");
}

//switch statement and break
int e = 1983;
switch (e)
{
    case 1980:
        Console.WriteLine("enter the crct pin:");
        break;
    case 1981:
        Console.Write("enter the crct pin:");
        break;
    case 1983:
        Console.WriteLine("entered the crct pin:");
        break;
    default:
        Console.WriteLine("invalid number");
        break;
}

//while loop
int n = 5;
int i = 0;
int j = 1;
int k = i + j;
Console.Write($"{i} {j}");
while (k <= n)
{
    Console.Write(k);
    i = j;
    j = k;
    k = i + j;
}

// do while
int a1 = 9;
do
{
    Console.WriteLine(a1);
    a1++;
} while (a1 <= 9);


// for loop
int b1 = 8;
int b2 = 5;
int b3 = 5;
for(int i1 = 0; i1 <= b2; i1++)
{
    for(int j1 = 0; j1 <= b3; j1++)
    {
        Console.Write(b1);
    }
    Console.WriteLine();
}



//continue 
int c1 = 1;
while (c1 < 30)
{
    if(c1<25 && c1 > 15)
    {
        continue;
    }
    Console.WriteLine(c1);
    c1++;
}

//go to
int d1 = 1;
for (int i2 = 0; i2 <= 10; i2++)
{
    if (i2 == 50)
    {
        goto last;
    }
    Console.WriteLine(i2);
}
last:
Console.WriteLine("end of the table");



//user defined function
static int add(int aa,int bb)
{
    int sum = aa + bb;
    return sum;
}
int ab = 12;
int bb = 10;
int sum = add(ab, bb);
Console.WriteLine(sum);


//user defined with no arguments
static int sum2()
{
    int cc = 10;
    int dd = 12;
    int sum1 = cc + dd;
    return sum1;
}
int sum1 = sum2();
Console.WriteLine(sum1);


//user defined but no return value
static void mul(int e1,int e2)
{
    int m = e1 * e2;
    Console.WriteLine(m);
}
int e1 = 10;
int e2 = 23;
mul(e1, e2);


//function overloading
int f1 = 10;
int f2 = 23;
int f3 = 32;
int f4=addtwo(f1, f2);
int f5=addthree(f1, f2, f3);
Console.WriteLine(f4);
Console.WriteLine(f5);
static int addtwo(int x,int y)
{
    return x + y;
}
static int addthree(int x,int y,int z)
{
    return x + y + z;
}
