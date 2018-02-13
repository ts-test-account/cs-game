using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    public class Program
    {
        static public void Main ()
        {       
            Actor actor = new Actor(CharacterStatusData.monsterdata[1]);
            actor.TestMethod();
            Console.WriteLine(actor.status.name);

            Actor actor2 = new Actor(CharacterStatusData.monsterdata[0]);
            CharacterList.AddCharacter(actor2);
            Console.WriteLine(CharacterList.characterlist[0].status.name);

            //—”‚ÌƒeƒXƒg
            Console.WriteLine(Utility.GetRandom());
        }
    }
}

