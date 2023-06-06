using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    	int index = 0;
        string[] x ={"+","-","-"};
        
        for(int i=0;i<4;i++)
        {
       	 Console.Write(x[index]);
         index++;
         
           if(index > 2){
           index=0;
           } 
         }
        
        
    }
}