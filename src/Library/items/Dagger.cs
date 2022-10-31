namespace RoleplayGame.Items
{
    /// <summary>
    /// </summary>
    public class Dagger : IAttackItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Dagger";
        }
    }
}