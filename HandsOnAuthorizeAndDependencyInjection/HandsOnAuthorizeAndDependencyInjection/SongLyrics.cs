using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAuthorizeAndDependencyInjection
{
    public class SongLyrics : ISong
    {
        public string MakeATune()
        {
            List<string> Lyrics = new List<string>()
            {"abc","xyz","123" };
            return "Tune Done";
        }
    }
}
