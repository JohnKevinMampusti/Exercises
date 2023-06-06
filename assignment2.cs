using System;

public class HelloWorld
{
    public static void triangle(int x)
    {

        {
            for (int i = 0; i <x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }


public static void Main(string[] args)
    {

        triangle(5);
    }
}