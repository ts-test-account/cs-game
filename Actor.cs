using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    public class Actor
    {
        public CharacterStatus status;
        
        //デフォルトコンストラクタ
        public Actor()
        {
            this.status = CharacterStatusData.monsterdata[0];
        }
        
        //引数付きコンストラクタ
        public Actor(CharacterStatus status)
        {
            this.status = status;
        }
        
        //テストメソッド
        public void TestMethod ()
        {
            Console.WriteLine ("Actor method");
        }
    }
}
