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
            Console.WriteLine("�����̃e�X�g");
            Console.WriteLine(Utility.GetRandom01());
            Console.WriteLine(Utility.GetSelectedRandom(0, 10));

            //�����L�����N�^�[��ǉ�
            CharacterList.AddIntialCharacter();

            //�����X�^�[��ǉ�
            CharacterList.AddMultipleMonster(5);

            //���X�g���̃L�����N�^����S�ĕ\��
            Console.WriteLine("�L�����N�^����S�ĕ\��");
            foreach (var item in CharacterList.characterlist)
            {
                Console.WriteLine(item.status.name);
            }
        }
    }
}
 
