using System;
using System.Collections.Generic;

namespace ConsoleGame{

    static public class CharacterList{
        static public List<Actor> characterlist = new List<Actor>();

        //Actorの追加
        static public void AddCharacter(Actor actor){
            characterlist.Add(actor);
        }

        //IDを指定してActorを追加
        static public void AddCharacter(int number)
        {
            Actor actor = new Actor(CharacterStatusData.monsterdata[number]);
            characterlist.Add(actor);
        }

        //標準入力で種類を指定してActorを追加
        static public void AddSpecifyCharacter()
        {
            Console.WriteLine("数値を入力して下さい。");
            int number = int.Parse(Console.ReadLine());
            AddCharacter(number);
        }

        //初期キャラクタを追加
        static public void AddIntialCharacter()
        {
            for (int i = 0; i < Constants.NumberOfInitialCharacter; i++)
            {
                AddSpecifyCharacter();
            }
        }

        //ランダムなモンスターを1体追加
        static public void AddRandomMonster()
        {

        }

    }
    
}