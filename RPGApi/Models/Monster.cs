using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RPGApi.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int MaxHp { get; set; }
        public int Attack {  get; set; }
        public int Defence { get; set; }

        public int XPReward { get; set; }
    }
}
