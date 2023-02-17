//This is a console application. You will see the output on the command line

string str = "Hello World!";
Console.WriteLine("str: " + str);

int a = 20;

Console.WriteLine("a: " + a);

Console.WriteLine("a & str: " + str + a);

//You can declare other varables too this way

long b = 10000000;
DateTime d = DateTime.Now;
char e = 'c';
int[] f = { 1, 2, 3 };

a = 30;

Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);
Console.WriteLine("e: " + e);

b = 10;
Console.WriteLine("b: " + b);

var g = 10;

Console.WriteLine("b datatype: " + b.GetType());
Console.WriteLine("g dattype: " + g.GetType());

dynamic h = 12;
Console.WriteLine("h: " + h);

dynamic i = "This is a string";
h = "This is a string";

Console.WriteLine("h: " + h);
Console.WriteLine("i: " + i);

//Constants

const int j = 20;

Console.WriteLine("j: " + j);

Console.WriteLine(j);
MyItem myItem = new MyItem();

myItem.PrintK();


class MyItem
{
    public readonly int k = 12;

    public MyItem()
    {
        k = 13;
    }
    
    public void PrintK()
    {
        Console.WriteLine(k);
    }
}

