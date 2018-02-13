using System;
using System.Collections.Generic;

namespace ConsoleGame{

    static public class CharacterList{
        static public List<Actor> characterlist = new List<Actor>();

        //Actorの追加
        static public void AddCharacter(Actor actor){
            characterlist.Add(actor);
        }
    }
    
}