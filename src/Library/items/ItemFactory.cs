namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        MagicWand = 3,
        Stick = 4,
        BreastPlate = 5,
        Dagger = 6,
        ChainMail = 7,


    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.MagicWand: return new MagicWand();
                case ItemType.Stick: return new Stick();
                case ItemType.BreastPlate: return new Breastplate();
                case ItemType.ChainMail: return new ChainMail();
                case ItemType.Dagger: return new Dagger();

            


                default: return null;
            }
        }
    }
}