using System.Runtime.ConstrainedExecution;

namespace RPGApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Intelligence { get; set; }
        public int Hitpoints { get; set; } = 100;
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int XP  { get; set; }
        public int CritChance { get; set; }
    }
}
