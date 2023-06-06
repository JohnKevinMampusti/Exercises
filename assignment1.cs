using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(int i=5; i>0; i--)
        {
        
            for(int j=i; j>0; j--)
            {
                Console.Write(" ");
            }
            for(int x=i;x<=5;x++)
            {
                Console.Write("*");
            }
                Console.WriteLine("");
        }
    }
}
