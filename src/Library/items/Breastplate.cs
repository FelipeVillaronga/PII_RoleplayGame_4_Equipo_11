namespace RoleplayGame.Items
{
    /// <summary>
    /// Coraza. Permite defenderse a grandes escalas.
    /// </summary>
    public class Breastplate : IDefenseItem
    {
        private int durability= 100;

        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Breastplate";
        }

        /// <summary>
        /// La durabilidad del elemento.
        /// </summary>
        /// <value></value>
        public int Durability
        {
            get
            {
                return this.durability;
            }
            set
            {
                this.durability+= value;
            }
        }
    }
}