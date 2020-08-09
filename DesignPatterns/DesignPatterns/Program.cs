using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Intermediate factory = new ActualClass();
            
            IFactoryPattern Classical= factory.GetSong(Console.ReadLine());
            Classical.songs(1);
            IFactoryPattern Rock = factory.GetSong(Console.ReadLine());
            Rock.songs(2);

        }
    }
}
