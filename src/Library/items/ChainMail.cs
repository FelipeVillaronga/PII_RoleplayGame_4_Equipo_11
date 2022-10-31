namespace RoleplayGame.Items
{
    /// <summary>
    /// </summary>
    public class ChainMail : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return "Chain Mail";
        }
    }
}