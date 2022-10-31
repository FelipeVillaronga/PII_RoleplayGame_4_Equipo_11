//Juan Magrini
using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    public class PowerGlove : IAttackItem
    {
        Characters.Character character;
        public List<Gemas> GemasAdded {get; set;}
        public int Damage {get; set;}
        public PowerGlove(IAttackItem one, IAttackItem two)
        {
            this.GemasAdded= new List<Gemas>();
            this.AttackPower = 5*(GemasAdded.Count);
        }
        public int AttackPower{get;}
        public void AddGemas(int amount)
        {
            foreach(Gemas gem in character.Gems)
            {
                if(character.Gems.Count>=amount)
                {
                    for(int i=0; i<=amount; i++)
                    {
                        character.Gems.Remove(gem);
                        GemasAdded.Add(new Gemas());
                    }
                }
            }
        }
    }
}
