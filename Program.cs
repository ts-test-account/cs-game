using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleGame
{
    public class Program
    {
        static public void Main ()
        {       
            //�����̃e�X�g
            Console.WriteLine(Utility.GetRandom());

            //�����L�����N�^�[��ǉ�
            CharacterList.AddIntialCharacter();
            //���X�g��2�Ԗڂ̃L�����N�^�̖��O��\��
            Console.WriteLine(CharacterList.characterlist[1].status.name);
        }
    }
}

