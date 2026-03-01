namespace RPGApi.Models
{
    public class BattleLog
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int MonsterId { get; set; }
        public Monster Monster { get; set; }

        public int Result { get; set; }
        public int XPGained {  get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
