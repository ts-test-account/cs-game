using System;

namespace ConsoleGame
{
    public static class CharacterStatusData{
    
        //データクラスの配列
        public static CharacterStatus[] monsterdata = new CharacterStatus[]
        {
            new CharacterStatus(0, "fighter", 1, 1, 1, 1, 1, 1, 1, 1, true),
            new CharacterStatus(0, "thief", 2, 1, 1, 1, 1, 1, 1, 1, false)
        };
    }
}

