// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region Stracture of a program
//Regions help you structure and organize your code

//namespace
//Contoin classes
//Like a dictionary made of us,or by us,and provide commands and tools we can use
//Note the syntax
//Keyword/reserved word namespace followed by the name of our namespace,opening and closing curly braces
namespace SHVFS_P101_GD08_Matt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int myFirstNumber = 5;
            var mySecondNumber = 8;

            Console.WriteLine($"my first number is:{myFirstNumber }");
            Console.WriteLine($"My second numbr is:{mySecondNumber}");
            Console.WriteLine();
        }
    }
}
#endregion