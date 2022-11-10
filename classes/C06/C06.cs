namespace SHVFS_P101_GD08_Matt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region C6
            //PrintAThing("some funny things!");
            //Console.ReadLine();

            //            var pokemon1=new Pokemon();
            //          pokemon1.EXP = 900;
            //        var pokemon2=new Pokemon(100,100,"LaLa");
            //      var pokemon3=new Pokemon() { EXP=9000,
            //     HP=100
            //    };
            //       Console.WriteLine($"P1:{pokemon1.EXP} |P2:{pokemon2.EXP}|P3: {pokemon3.EXP}");
            //     Console.ReadLine();
            var pokemon1 = new Pokemon(0, 100, "CutiePatootie", "Devil");
            Console.WriteLine($"Pokemon1!|EXP:{pokemon1.EXP}|HP:{pokemon1.HP}|Name:{pokemon1.Name}|Secret Name>:):{pokemon1.GetSecretName()}");

            #endregion
        }
        /*     public static void PrintAThing(string[] args);
             {
     Console.WriteLine($"the thing is{stringThing} "); 

             }
         pubilc static void PrintAThing(int anotherThing)
         {
             Console.WriteLine($"The thing is:{anotherThing}");

         }
         public static void PrintAThing(string stringThing, string anotherStringThing)
         {
             Console.WriteLine($"the thing is:{stringThing},and the other thing is {anotherStringThing}");

         }
     }*/
        public class Pokemon
        {
            public int EXP;
            public int HP;
            public string Name;
            //classes,flieds,method,methods,etc,are implicitly private in c#
            //  private string SecretName;
            protected string SecretName;
            public Pokemon() { }
            public Pokemon(int exp, int hp, string name, string secretName)
            {
                Console.WriteLine("dkfdflj");
                EXP = exp;

                HP = hp;
                Name = name;
                SecretName = SecretName;

            }
            public string GetSecretName()
            {
                return SecretName;
            }
            //overrides/virtual methods
            public virtual void DeclareForBattle()
            {
                Console.WriteLine("I am readyyyyyyyy for battle!");

            }
        }
        //inheritance
        //OO/Polymorphism
        public class Pikachu : Pokemon
        {
            public Pikachu(int exp, int hp, string name, string secretName) : base(exp, hp, name, secretName)
            {
                Console.WriteLine("123");
            }
            public override void DeclareForBattle()
            {
                Console.WriteLine("I am Pikachuuuuu!");
                base.DeclareForBattle();

            }
            public void PrintDetails()
            {
                Console.WriteLine($"Pokemon1!|EXP:{EXP}|HP:{HP}|Name:{Name}|Secret Name >:):{SecretName}");
            }
        }
    }
}


