using RoleplayGame.Scenarios;
using RoleplayGame.Characters;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Character first= CharacterFactory.GetCharacter(CharacterType.Troll, "Alejandra");
            Character second= CharacterFactory.GetCharacter(CharacterType.Elf, "Juana");
            Character third= CharacterFactory.GetCharacter(CharacterType.Wizard, "Denis");
            Character forth= CharacterFactory.GetCharacter(CharacterType.Troll, "Toretto");
            IScenario scenario = new FourMembersScenario(first, second, third, forth);
            scenario.Setup();
            scenario.Run();
        }
    }
}
