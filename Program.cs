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
            Console.WriteLine("乱数のテスト");
            Console.WriteLine(Utility.GetRandom01());
            Console.WriteLine(Utility.GetSelectedRandom(0, 10));

            //初期キャラクターを追加
            CharacterList.AddIntialCharacter();

            //モンスターを追加
            CharacterList.AddMultipleMonster(5);

            //リスト内のキャラクタ名を全て表示
            Console.WriteLine("キャラクタ名を全て表示");
            foreach (var item in CharacterList.characterlist)
            {
                Console.WriteLine(item.status.name);
            }
        }
    }
}
 
