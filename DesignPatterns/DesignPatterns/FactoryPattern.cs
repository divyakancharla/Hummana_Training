using System;
using System.Collections.Generic;
using System.Text;
using Calci;
namespace DesignPatterns
{
   public interface IFactoryPattern
    {
        void songs(int time);
    }
    class Classical:IFactoryPattern
    {
        void IFactoryPattern.songs(int time)
        {
            Console.WriteLine("Classical Has the durations of", time);
        }
    }
    class Rock : IFactoryPattern
    {
        void IFactoryPattern.songs(int time)
        {
            Console.WriteLine("Rcok Has the durations of", time);
        }
    }
   public abstract class Intermediate
    {
        public abstract IFactoryPattern GetSong(string song);
    }
    class ActualClass : Intermediate
    {
        public override IFactoryPattern GetSong(string song)
        {
            switch (song)
            {
                case "Classical":
                    return new Classical();
                case "Rock":
                    return new Rock();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", song));
            }

        }
    }
}
