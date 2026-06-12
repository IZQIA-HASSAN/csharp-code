using System;
using System.Xml;

namespace helloworld
{
    class Program { 

    static void Main(string[] args)
    {
            //var a = 10;
            //var b = 20;
            //var c = 30;
            //Console.WriteLine(c > b || b > c );

            // taking user input in c-sharp , 
            //Console.WriteLine("type yopur  username");
            //string userName = Console.ReadLine();
            //Console.WriteLine("suername is " + userName);

            //Console.WriteLine("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("your age is " + age);

            //Maths in c-sharp
            // Console.WriteLine(Math.Max(10,20));
            // Console.WriteLine(Math.Min(10,20));


            // Console.WriteLine(Math.Sqrt(4));
            // //Console.WriteLine(Math.Abs(-4.121));
            // Console.WriteLine(Math.Round(9.99));

            // while loops in c sharp 

                // int i = 10;
                // while (i > 5){
                //     Console.WriteLine(i);
                //     i--;
                // };
// int j = 10;
//                 do
//             {
//                 Console.WriteLine(j);
//                 j--;
//             }while(j != 0);


// for(int k = 10 ; k > 0 ; k--)
//             {
//                 Console.WriteLine(k);
//             }

//             for(int l = 0 ; l < 10 ; l++)
//             {
//                 Console.WriteLine(l);
//                 for (int m = 0 ; m < 10 ; m++)
//                 {
//                     Console.WriteLine(m);
//                 }
//             }

// for each loop in c-sharp 

// string[] cars = {"bmw" , "audi" , "mercedes"};
// foreach(string i in cars)
//             {
//                 Console.WriteLine(i);
//             }

// ARRAYS IN C-SHARP
 int[] mynum = {10,20,30,40};
//  mynum[0] = 0;
// //  Console.WriteLine(mynum);
// foreach(int i in mynum)
//             {
//                 Console.WriteLine(i);
//             }

// Console.WriteLine(mynum.Length);

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// for (int i = 0; i < cars.Length; i++) 
// {
//   Console.WriteLine(cars[i]);
// }

int[] number  = {3,2,1,4,5,6};
// Array.Sort(number);
// foreach(int i in number)
//             {
//                 Console.WriteLine(i);
//             }

// Console.WriteLine(number.Max());
// Console.WriteLine(number.Sum());
// Console.WriteLine(number.Min());

int[,] integers = {{1,2,3} , {4,5,6}};
Console.WriteLine(integers[0,2]);

// integers[0,0] = 10;
Console.WriteLine(integers[0,0]);

foreach(int i in integers)
            {
                Console.WriteLine(i);
            }





        }
    }                      
    

}