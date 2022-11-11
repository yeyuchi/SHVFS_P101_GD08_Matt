namespace SHVFS_P101_GD08_C7_Matt
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;
        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
    public class GameObject
    {
        public Position pos;
        public string name;

        public GameObject(string name, Position pos)
        {
            this.pos = pos;
            this.name = name;
        }

        public bool CheckPosition(GameObject go)
        {
            if (go.pos.X == pos.X && go.pos.Y == pos.Y && go.pos.Z == pos.Z)
            {
                return true;
            }
            return false;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            GameObject[] go = new GameObject[5];
            go[0] = new GameObject("0", new Position(1, 2, 3));
            go[1] = new GameObject("1", new Position(2, 4, 12));
            go[2] = new GameObject("2", new Position(4, 4, 12));
            go[3] = new GameObject("3", new Position(1, 2, 3));
            go[4] = new GameObject("4", new Position(20, 4, 12));
            for (int i = 0; i < go.Length - 1; i++)
            {
                for (int j = i + 1; j < go.Length; j++)
                {
                    if (go[i].CheckPosition(go[j]))
                    {
                        Console.WriteLine($"{go[i].name} and {go[j].name} have the same position");
                    }
                }
            }
        }

    }

}