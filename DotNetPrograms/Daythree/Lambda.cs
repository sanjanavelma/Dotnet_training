using System;
class Lambda
{
    public void Example()
{
        int Square(int x)
        {
            return x * x;
        }
        Func<int, int> squareLambda = x => x * x;

        Console.WriteLine(Square(4));
        Console.WriteLine(squareLambda(4));
}
}
