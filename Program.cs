using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    public class Program
    {
        static public void Main ()
        {       
            Actor actor = new Actor(CharacterStatusData.monsterdata[0]);
            CharacterList.AddCharacter(actor);
            Console.WriteLine(CharacterList.characterlist[0].status.name);

            //—”‚ÌƒeƒXƒg
            Console.WriteLine(Utility.GetRandom());

            CharacterList.AddSpecifyCharacter();
            Console.WriteLine(CharacterList.characterlist[1].status.name);
        }
    }
}

