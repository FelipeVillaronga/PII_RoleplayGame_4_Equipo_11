
namespace RoleplayGame.Items
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
    /// </summary>
    public class MagicWand : IAttackItem
    {
        public MagicWand()
        {
            Magic MagicWandGem = new Magic();
            this.MagicDMGPart = MagicWandGem.AttackPower;
        }
        public int MagicDMGPart { get; set; }


        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10+this.MagicDMGPart;
            }
        }


        public override string ToString()
        {
            return "Magic Wand";
        }
    }
}