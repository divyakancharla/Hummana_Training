using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace HandsOnAuthorizeAndDependencyInjection
{
    public class SongOriginal
    {
        //private readonly ISong _DIO;
        public SongLyrics song;
        private readonly ISong _song=null;
        public SongLyrics PropertyInjection { get; set; }
       // [InjectionConstructor]
        public SongOriginal(ISong _song)
        {
            this._song = _song;
        }
        public SongOriginal(string str)
        {
            str = null;
        }
        public static ISong SongObject()
        {

            return new SongLyrics();
        }
        
        public string GetTune()
        {
            return _song.MakeATune();
         }
        //Unity Container
        public string check()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ISong, SongLyrics>();
            SongOriginal obj = container.Resolve<SongOriginal>();
           return obj.GetTune();

        }
    }
}
