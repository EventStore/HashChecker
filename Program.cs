using System;

namespace HashDetector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: mono HashChecker name1 name2");
                Environment.Exit(1);
            }

            string a = args[0];
            string b = args[1];

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            
            IHasher xxHash = new XXHashUnsafe();
            Console.WriteLine("a XXHashUnsafe: " +xxHash.Hash(a));
            Console.WriteLine("b XXHashUnsafe: " +xxHash.Hash(b));

            IHasher murmur3A = new Murmur3AUnsafe();
            Console.WriteLine("a Murmure3AUnsafe: " + murmur3A.Hash(a));
            Console.WriteLine("b Murmure3AUnsafe: " + murmur3A.Hash(b));
        }
    }
}
