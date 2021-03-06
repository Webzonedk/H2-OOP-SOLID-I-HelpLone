using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This Class is representing the Wizard and is a part of the interfaces ICharacter, IMagicMove, ImagicAttack
namespace HelpLone
{

        public class Wizard : ICharacter, IMagicMove, ImagicAttack
    {

            public void Die()
            {
                Console.WriteLine("I'm dying");
            }

            public void Fight()
            {
                Console.WriteLine("I'm fighting");
            }

            public void Heal()
            {
                Console.WriteLine("I'm healing");
            }

            public void Teleport(int x, int y)
            {
                Console.WriteLine("I'm teleporting to " + x + " " + y);
            }

            public void ThrowFrostNova()
            {
                Console.WriteLine("I'm throwing my frost nova");
            }

            public void ThrowMagicMisile()
            {
                Console.WriteLine("I'm throwing a magic misile");
            }
        }

    
}
