using RPG_Battler.Character.Upgrades;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public Dictionary<string, Equipment> Equipment { get; set; }

        public Hero()
        {       
        }

        public void LevelUp()
        {
        }

        public void CalculateTotals()
        {
        }
    }
}
