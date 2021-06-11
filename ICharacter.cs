using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    //This is the interface for the Charakter, containing main methods
    interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();
    }
}
