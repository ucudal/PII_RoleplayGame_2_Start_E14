using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : ISpell
    {
        public Spell[] Spells { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}