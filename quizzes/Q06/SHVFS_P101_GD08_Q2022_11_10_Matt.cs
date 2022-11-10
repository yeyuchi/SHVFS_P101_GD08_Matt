
namespace SHVFS_P101_GD08_Matt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string a, reply;
            int i = 0;
            string[] names={ "Matt","people", "person","human","Mat","Ma"};
            Random rand = new Random();
            int name = rand.Next(names.Length);
            Console.WriteLine("Welcome you to play the game,and what's your name");
            Console.ReadLine();
            Console.WriteLine("What a good name!Then you can guess the word!");
            Console.WriteLine("The words are Matt,People,person,human,Mat,Ma");
           reply= Console.ReadLine();
            do
            {
                if (reply == names[name])
                {
                    Console.WriteLine("You are right!");                  
                }
                else if (reply != names[name])
                {
                    Console.WriteLine("Wrong");
                    Console.WriteLine("You can try again");
                    Console.ReadLine();
                    Console.Clear();
                } i = i + 1;
            }while(reply == names[i]);
                Console.WriteLine("Good job!The game is finished!");
                Console.ReadLine();
                                
          

        }
    }
}