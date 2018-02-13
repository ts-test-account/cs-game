using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    public class Program
    {
        static public void Main ()
        {       
            //乱数のテスト
            Console.WriteLine(Utility.GetRandom());

            //初期キャラクターを追加
            CharacterList.AddIntialCharacter();
            //リストの2番目のキャラクタの名前を表示
            Console.WriteLine(CharacterList.characterlist[1].status.name);
        }
    }
}

