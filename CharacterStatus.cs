using System;

namespace ConsoleGame
{
    public struct CharacterStatus {
        
        int id;
        public string name;        
        int hp;
        int mp;
        int str;
        int ac;
        int ev;
        int agi;    
        int intl;
        int defaultskill;
        bool isPlayer;
        
        //引数付きコンストラクタ
        public CharacterStatus(int id, string name, int hp, int mp, int str, int ac, int ev, int agi, int intl, int defaultskill, bool isPlayer)
        {
            this.id = id;
            this.name = name;
            this.hp = hp;
            this.mp = mp;
            this.str = str;
            this.ac = ac;
            this.ev = ev;   
            this.agi = agi;
            this.intl = intl;
            this.defaultskill = defaultskill;
            this.isPlayer = isPlayer;    
        }
    }
}

