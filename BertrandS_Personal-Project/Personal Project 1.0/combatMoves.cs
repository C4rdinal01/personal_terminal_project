using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project_1._0
{
    public class combatMoves
    {
        public int Damage;
        public int ManaCost;
        public bool Stuns;
        public bool Bleeds;

        Dictionary<string, combatMoves> Moves = new Dictionary<string, combatMoves>()
        {
            { "Slash", new combatMoves { Damage = 5, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Crippling Slash", new combatMoves { Damage = 8, ManaCost = 2, Stuns = true, Bleeds = false }},
            { "Backstab", new combatMoves { Damage = 10, ManaCost = 2, Stuns = false, Bleeds = true }},
            { "Claw Slash", new combatMoves { Damage = 3, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Bite Attack", new combatMoves { Damage = 3, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Dagger Attack", new combatMoves { Damage = 5, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Punch Attack", new combatMoves { Damage = 3, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Club Attack", new combatMoves { Damage = 8, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Crushing Blow", new combatMoves { Damage = 10, ManaCost = 2, Stuns = true, Bleeds = false }},
            { "Maiming Bite", new combatMoves { Damage = 5, ManaCost = 2, Stuns = false, Bleeds = true }},
            { "Stab", new combatMoves { Damage = 5, ManaCost = 0, Stuns = false, Bleeds = false }},
            { "Trip", new combatMoves { Damage = 2, ManaCost = 0, Stuns = true, Bleeds = false }},
            { "Sweeping Strike", new combatMoves { Damage = 8, ManaCost = 2, Stuns = true, Bleeds = false }},
            // { "", new combatMoves { Damage = 0, ManaCost = 0, Stuns = false, Bleeds = false }},
        };
    }

}
