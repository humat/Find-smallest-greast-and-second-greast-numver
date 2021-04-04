using System;
 
namespace CSharpExamples
{
    class Programs
    {
        static void Main(string[] args)
        {
            int num1=50;
            int num2=21;
            int num3=13;
            int num4=35;
 
            if(num1>num2 && num1>num3 && num1>num4){
                Console.WriteLine("Number1 is the highest number "+ num1);    
            }
 
            if(num2>num1 && num2>num3 && num2>num4){
                Console.WriteLine("Number2 is highest number"+num2);    
            }
 
            if(num3>num1 && num3>num2 && num3>num4){
                Console.WriteLine("The greatest number is: "+num3);    
            }
            if (num4>num1 && num4>num2 && num4>num3 )
            {
                Console.WriteLine("The greatest number is:"+num4);
            }
            //To find second highest number
        
            if(num1<num2 && num1>num3 && num1>num4 || num1<num3 && num1>num2 && num1>num4 || num1<num4 && num1>num2 &&num1>num3){
                Console.WriteLine("The second highest number is:"+num1);
            } 
            if(num2<num1 && num2>num3 && num2>num4|| num2<num3 && num2>num1 && num2>num4 || num2<num4 &&num2>num1 && num2>num3){
            Console.WriteLine("The second highest number is:"+num2);
        }
        if(num3<num1 && num3>num2 && num3>num4|| num3<num2 && num3>num1 && num3>num4 || num3<num4 && num3>num1 && num3>num2){
            Console.WriteLine("The second highest number is:"+num3);
        }
        if(num4<num1 && num4>num2 && num4>num3|| num4<num2 && num4>num1 && num4>num3 || num4<num3 && num4>num1 && num4>num2){
            Console.WriteLine("The second highest number is:"+num4);
        }
    
            //To fine smallest value
             if(num1<num2 && num1<num3 && num1<num4){
                Console.WriteLine("The smallest number is: "+ num1);    
            }
            
 
            if(num2<num1 && num2<num3 && num2<num4){
                Console.WriteLine("The smallest number is:"+num2);    
            }
 
            if(num3<num1 && num3<num2 && num3<num4){
                Console.WriteLine("The smallest number is:"+num3);    
            }
            if (num4<num1 && num4<num2 && num4<num3 )
            {
                Console.WriteLine("The smallest number is:"+num4);
            }
        }
    }
}

