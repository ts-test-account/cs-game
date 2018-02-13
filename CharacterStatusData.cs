using System;

namespace ConsoleGame
{
    public static class CharacterStatusData{
    
        //データクラスの配列
        public static CharacterStatus[] monsterdata = new CharacterStatus[]
        {
            new CharacterStatus(0,  "noname",        0,  0,  0,  0,  0,  0,  0,  0, true),
            new CharacterStatus(1,  "warrior",       40, 3,  30, 10, 15, 15, 5,  1, true),
            new CharacterStatus(2,  "hunter",        30, 10, 20, 5,  18, 20, 10, 3, true),
            new CharacterStatus(3,  "priest",        10, 50, 5,  3,  10, 15, 20, 1, true),
            new CharacterStatus(4,  "sorcerer",      15, 50, 5,  3,  10, 15, 20, 7, true),
            new CharacterStatus(5,  "monk",          50, 10, 20, 8,  20, 25, 5,  1, true),
            new CharacterStatus(6,  "oak",           26, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(7,  "goblin",        20, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(8,  "green-slime",   18, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(9,  "kobold",        20, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(10, "wild-dog",      11, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(11, "pixie",         5,  0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(12, "big-spider",    33, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(13, "big-cockroach", 30, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(14, "dragon",        50, 0,  10, 3,  0,  0,  0,  0, false),
            new CharacterStatus(15, "snake",         10, 0,  20, 20, 0,  0,  0,  0, false),
        };
    }
}

