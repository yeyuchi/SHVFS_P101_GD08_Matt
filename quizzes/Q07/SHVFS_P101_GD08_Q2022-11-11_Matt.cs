namespace SHVFS_P101_GD08_Matt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var GO1 = (1, 2, 3);
            var GO2 = (2, 3, 4);
            var GO3 = (1, 2, 3);
            var GO4 = (3, 4, 5);

        }
        public class GameObject
        {
            public int X;
            public int Y;
            public int Z;
            public GameObject() { }
            public GameObject(int x,int y,int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

    }
}
