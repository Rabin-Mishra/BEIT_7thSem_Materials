using System;
class Complex
{
    public int R, I;
    public Complex(int r, int i)//Constructor
    {
        R = R;
        I = I;
    }
    public static Complex Operator +(Complex c1, Complex c2){
        return new Complex(c1.R+c2.R, c1.I+c2.I);
}
}
//main program
class Program
{
    static void Main()
    {
        Complex C1 = new Complex(3, 2);
        Complex C2 = new Complex(1, 4);
        Complex res = C1 + C2;
        Console.WriteLine($"Result is :{res.R}+{res.I}i");//output: 4+6i

    }
}