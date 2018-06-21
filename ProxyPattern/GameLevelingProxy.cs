using System;

namespace ProxyPattern
{
    public class GameLevelingProxy
    {
        private GameLeveling gameLeveling = new GameLeveling();

        public void Play()
        {
            Console.WriteLine("查看是否符合等级要求");
            gameLeveling.Play();
            Console.WriteLine("查看是否符合等级要求");
        }

    }
}
