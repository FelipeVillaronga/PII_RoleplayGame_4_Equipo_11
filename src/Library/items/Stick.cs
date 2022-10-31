namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo. Permite atacar y defender.
    /// </summary>
    public class Stick : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}