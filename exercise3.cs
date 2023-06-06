using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(int i=0; i<=4; i++)
        {
            for(int y=4;y>=i; y--)
            {
                Console.Write("*");
            }
                Console.WriteLine(" ");
        }
    }
}