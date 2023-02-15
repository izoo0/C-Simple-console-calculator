using System;

namespace calculator{
     class Calculator{
          public static int a;
          public static int b;

         
          public static void Main(string[] args)
          {
               Console.WriteLine("Select the operation");
               Console.WriteLine(
                    "1. Multiplication\n"+
                    "2. Addition\n" +
                    "3. Subtraction\n"+
                    "4. Division"
               );

               int option = Convert.ToInt32(Console.ReadLine());

               if(option == 1){
                    Console.WriteLine("Enter the first number");
                    a = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the Second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int c = a*b;
                    Console.WriteLine("The answer after" +" " +option +" " +c);
               }else
               if(option == 2){
                    Console.WriteLine("Enter the first number");
                    a = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the Second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int c = a+b;
                    Console.WriteLine("The answer after" +" " +option +" " +c);
               }else
               if(option == 3){
                    Console.WriteLine("Enter the first number");
                    a = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the Second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int c = a-b;
                    Console.WriteLine("The answer after" +" " +option +" " +c);
               }else
               if(option == 4){
                    Console.WriteLine("Enter the first number");
                    a = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Enter the Second number");
                    b = Convert.ToInt32(Console.ReadLine());
                    int c = a/b;
                    Console.WriteLine("The answer after" +" " +option +" " +c);
               }else
               {
                    Console.WriteLine("Please Select one option");
               }
          }
     }
}
