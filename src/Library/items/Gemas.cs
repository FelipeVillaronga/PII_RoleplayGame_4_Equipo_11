//Juan Magrini

namespace RoleplayGame.Items
{
    public class Gemas: IItem
    {
        public int Power {get; set;}
        public Gemas()
        {
            this.Power=5;
        }
        
    }
}