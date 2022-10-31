using RoleplayGame.Scenarios;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IReporter reporter= new ConsoleReporter();

            Character first= CharacterFactory.GetCharacter(CharacterType.Troll, "Alejandra");
            Character second= CharacterFactory.GetCharacter(CharacterType.Elf, "Juana");
            Character third= CharacterFactory.GetCharacter(CharacterType.Wizard, "Denis");
            Character forth= CharacterFactory.GetCharacter(CharacterType.Troll, "Toretto");

            FourMembersScenario scenario = new FourMembersScenario(first, second, third, forth);
            scenario.FirstVsSecond.Reporter= new ConsoleReporter();
            scenario.ThirdVsForth.Reporter= new ConsoleReporter();

            scenario.Setup();
            scenario.Run();
            scenario.Winners.Reporter= new ConsoleReporter();
            scenario.Finale();
    }
}
}
