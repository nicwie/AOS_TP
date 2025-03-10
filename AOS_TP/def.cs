using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_TP
{
    internal class Def : Node
    {
        private string our_army;
        private string their_army;

        Def (string our_army, string their_army)
        {
            this.our_army = our_army;
            this.their_army = their_army;
        }   
    }
}
