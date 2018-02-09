using System;
using System.Collections.Generic;

namespace ConsoleGame{

    public class characterlist{
        var characterlist = new List<Actor>();

        //Actorの追加
        public void AddCharacter(Actor actor){
            characterlist.Add(actor);
        }
    }
    
}