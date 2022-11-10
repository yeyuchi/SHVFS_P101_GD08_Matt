using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace SHVFS_P101_GD08_Matt_C05
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //    //PrintHello();
            //    //PrintHelloName("Chris");
            //         var expArray = new[] { 23, 345, 22, 20, 1, 99, 9999, 2, 3 };
            //    /   var maxEXP = GetMaxEXP(expArray);
            //    Console.WriteLine($"Our max exp is:{maxEXP}");
            //   Console.ReadLine();
            //   }
            ////   var scores = new int[5] { 1,  2, 3, 4, 5, };
            ////            var input = "";
            ////while (true )is very danger 
            //          while (true)
            //        {
            //          Console.Clear();
            //        Console.WriteLine("Type 'y'to quit");
            //      input=Console.ReadLine();
            //    if(input=="y")
            //      {
            //    break;
            //         }
            //        Console.WriteLine("Did not exit the loop...");

            //   }
            //    Console.WriteLine("quitting");
            //    Console.ReadLine();


            //continue
            //  proceeds to the next iteration of the loop
            //    for (var i = 0; i < 10; i++) 
            //    {
            //        if (i==4)
            //        {
            //          //  break;
            //            continue
            //        }
            ////        Console.WriteLine(i);
            ////    }
            ////    Console.ReadLine();
            //public static void PrintHello()
            ////{
            ////    Console.WriteLine("Hello!");
            ////}
            //public static void PrintHelloName(string name)
            ////{
            ////    Console.WriteLine($"Hello,{name}");
            ////}
            //public static int GetMaxEXP(int[] intArray)
            ////{

            ////    var maximum = intArray[0];
            //    for (var i = 0; i < intArray.Length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            continue;
            //        }
            //        if (maximum < intArray[i])
            //        {
            //            maximum = intArray[i];
            //        }
            //    }


            //    return maximum;
            string input;
            int radius;
            double myCircumference = 0;
            double myArea = 0;

            do
            {
                Console.WriteLine("Please enter a radius!");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out radius) || !TryCircleOops(radius, myCircumference, myArea));
            Console.WriteLine($"Your circle has a radius of {radius},a circumference of{myCircumference},and a area of {myArea}");
            Console.ReadLine();




            //var smileyFace = ReturnSmileyFace();
            //Console.WriteLine(smileyFace);
            //Console.ReadLine();
            //pubilc static string ReturnSmileyFace()
            //{
            //    Console.WriteLine("returning a smiley face ...");
            //    return ":)";
            //}
            public static bool TryCircle(int radius, out double circumference, out double area)
            {
                //{ circumference = 0; area = 0;
                if (radius == 0)
                {
                    Console.WriteLine("you need  to enter a radius for a circle ");

                    return false;

                }
                circumference = Math.PI * radius * 2;
                area = Math.PI * Math.Pow(radius, 2);
                return true;
            }
            Console.ReadLine();



            {
              public Pokemon
            }

            


        }

             
        }
        } 
    



//method/functions are blocks of code that Do thins that we can reuse
//we have already been using them ...WriteLine,ReadLine,Clear,etc.
//They can have input ..parameters in the definition/arguments that are passed...and outputs..return

//this method has no parameters in its signaturs and returns nothing(void)
