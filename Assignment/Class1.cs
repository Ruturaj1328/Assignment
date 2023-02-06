using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Assignment
{
    internal class Class1
    {                               // sum of Two integer
        static void Main(string[] args)
        {

            int a = 10, b = 20, sum;
            a = Convert.ToInt32(a);
            b = Convert.ToInt32(b);
            sum = a + b;
            Console.WriteLine($"sum of two interger = {sum}");
        }
    }
}

namespace Assignment
{                              //   display number from 1-100
    internal class Class2
    {
        static void Main(string[] args)
        { //  using for
            for(int i=1; i<=100; i++)
            {
              Console.WriteLine(i);
          }
            // using while
            int j = 1;
            while(j<=100)
            {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}



namespace Assignment
{                           // display even number from 1 to 100
    internal class Class3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}



namespace Assignment
{
    internal class Class4
    {                              // dispaly odd number form 1 to 100
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=100)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}


namespace Assignment
{
    internal class Class6
    {                                            // fimd Max number from given three number
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1>=num2 && num1>=num3)
            {
                Console.WriteLine($"max numbner is {num1}");
            }
            else if(num2>=num1 && num2>=num3)
            {
                Console.WriteLine($"max number is {num2}");
            }
            else
            {
                Console.WriteLine($"max number is {num3}");
            }
        }
    }
}


namespace Assignment
{            
    internal class Class8
    {                                                // frist 10 even number
        static void Main(string[] args)
        {
            
            for(int i=1;i<=20;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

namespace Assignment
{                                    //  display max number from array
    internal class Class9
    {
        static void Main(string[] args)
        {
            int[]arr=new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for(int i=1; i<arr.Length;i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}


namespace Assignment
{
    internal class Class10
    {                                 // Alternate number from array
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 4, 2, 5, 7, 8, 20, 19, 6, 30 };

            for(int i=0;i<=arr.Length;i=i+2)
            {
                Console.WriteLine(arr[i]);

            }                
        }
    }
}

namespace Assignment
{
    internal class Class11
    {                                          // create table of a number
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                int reslut = i * num;
                Console.WriteLine(reslut);
            }
        }
    }
}


namespace Assignment
{
    internal class Class12
    {                                  // find given number is odd or even
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}



namespace Assignment
{
    internal class Class14
    {                                     //  Calculate factorial of number
        static void Main(string[] args)
        {
            int fact = 1;
            int n= Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine(fact);
        }
    }
}


namespace Assignment
{
    internal class Class15
    {                                      //    calculate a power b
        static void Main(string[] args)
        {
            int result = 1;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=b;i++)
            {
                result=result*a;
            }
            Console.WriteLine(result);
        }
    }
}



namespace Assignment
{
    internal class Class22
    {                                 //    reverse array of 5 number
        static void Main(string[] args)
        {
            int[] arr= new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }                                                         // 1 2 3 4 5
            Console.WriteLine("----------------------");

            for(int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}


namespace Assignment
{                               //   
    internal class Class7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 1; i <= arr.Length; i ++)
            {
                int result = i + 1;
                Console.WriteLine(arr[i]);

            }
        }
    }
}


namespace Assignment
{                         //  display area if Circle
    internal class Class17
    {
        static void Main(string[] args)
        {
           int radius=Convert.ToInt32 (Console.ReadLine());
            
            double area = Math.PI* radius * radius;
            Console.WriteLine(area);
        }
    }
}

namespace Assignment
{                            //   accept lenght and breadth of rectangle find perimeter
    internal class Class18
    {
        static void Main(string[] args)
        {
            int length=Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());

            int area = 2*(length + breadth);
            Console.WriteLine(area);

        }
    }
}



namespace Assignment
{
    internal class Class19
    {                              // aceept two angle of triangle and find 3rd angle
        static void Main(string[] args)
        {
            int angle1 = Convert.ToInt32(Console.ReadLine());
            int angle2 = Convert.ToInt32(Console.ReadLine());
           
            double angle3=180-(angle1+angle2);
            Console.WriteLine(angle3);
        }
    }

}


namespace Assignment
{
    internal class Class23
    {                                   // swap two vaule using 3rd variable
        static void Main(string[] args)
        {
            int temp = 0;
            int a= Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine( $"a = {a} and b = {b}");
        }
    }
}


namespace Assignment
{
    internal class Class24
    {                               // swap two vaule without using 3rd variable
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a} and b1 = {b}");
        }
    }
}



namespace Assignment
{
    internal class Class30
    {                    // check two array are  equal
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[] { 1, 2, 3, 8, 5, 6 };

           int n1= arr1.Length;
            int n2= arr2.Length;

            if(n1==n2 )
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not Equal");
            }

          
        }
    }
}

namespace Assignment
{
    internal class Class31
    {                               // check given number is Armstrong or not
        static void Main(string[] args)
        {
            int r, temp,sum=0;
            int num=Convert.ToInt32(Console.ReadLine());
            temp = num; //153
            while(num>0) 
            {
                r = num % 10; // r=3  5 1
                sum = sum + r * r * r; // 9+125+1
                num= num / 10;// 153 15 

            }
            //Console.WriteLine(sum);

            if(temp==sum)
            {
                Console.WriteLine(" Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong number");
            }


        }
    }
}


namespace Assignment
{
    internal class Class34
    {                              //  find given number is plaindrome or not
        static void Main(string[] args)
        {
            int r, orignal,Reverse=0;
            int num=Convert.ToInt32(Console.ReadLine());
            orignal = num;//12321
            
            while(num>0) 
            {
              
                r = num % 10;
                Reverse = Reverse*10 + r;
              
                num = num / 10;
            }
            Console.WriteLine(Reverse);

            if(orignal==Reverse)
            {
                Console.WriteLine("Is Palindrome Number");
            }
            else
            {
                Console.WriteLine("Is Not Palindrome Number");
            }
        }
    }
}


namespace Assignment
{
    internal class Class32
    {                                   // sum of all digit
        static void Main(string[] args)
        {
            int r, sum = 0;
            int num=Convert.ToInt32(Console.ReadLine());
            while(num>0)//153 0
            {
                r= num % 10;//3 5 1
                sum = sum + r;//3+5=8+1=9
                num = num / 10;//15 1 0
            }
            Console.WriteLine(sum);
        }
    }
}


namespace Assignment
{
    internal class Class49
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------");


            for(int i=4;i>=1;i--)
            {
                for(int j=i; j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}


namespace Assignment
{
    internal class Class50
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=3;i++)
            {
                for (int space=1;space<=3-i;space++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= ((2*i)-1); j++) 
                {
                   
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

