using System.Collections.Generic;
using RoleplayGame.Characters;
using System;

namespace RoleplayGame.Scenarios;
public class FourMembersScenario : IScenario
{

    public FourMembersScenario(Character first, Character second, Character third, Character forth)
    {
        this.First= first;
        this.Second= second;
        this.Third= third;
        this.Forth= forth;
        this.Characters= new List<Character> () {this.First, this.Second, this.Third, this.Forth};
    }
    private Character first {get; set;}
    private Character second {get; set;}
    private Character third {get; set;}
    private Character forth {get; set;}

    public Character First {get; set;}
    public Character Second {get; set;}
    public Character Third {get; set;}
    public Character Forth {get; set;}

    public List<Character> Characters {get; set;}
    public void Setup()
    {
        foreach(Character character in Characters)
        {
            foreach(Items.IItem item in character.Items)
            {
                character.Items.Remove(item);
            }
        }
    }
    public void Run()
    {
        Encounters.Encounter FirstVsSecond= Encounters.EncounterFactory.GetEncounter(Encounters.EncounterType.Attack, this.First, this.Second);
        Encounters.Encounter ThirdVsForth= Encounters.EncounterFactory.GetEncounter(Encounters.EncounterType.Attack, this.Third, this.Forth);
        Console.WriteLine(FirstVsSecond.ToString());
        FirstVsSecond.DoEncounter();
        Console.WriteLine(ThirdVsForth.ToString());
        ThirdVsForth.DoEncounter();
        if(!this.First.IsDead)
        {
            if(!this.Third.IsDead)
            {
                Encounters.Encounter FirstVsThird= Encounters.EncounterFactory.GetEncounter(Encounters.EncounterType.Attack, this.First, this.Third);
                Console.WriteLine(FirstVsThird.ToString());
                FirstVsThird.DoEncounter();
            }
            else
            {
                Encounters.Encounter FirstVsForth= Encounters.EncounterFactory.GetEncounter(Encounters.EncounterType.Attack, this.First, this.Forth);
                Console.WriteLine(FirstVsForth.ToString());
                FirstVsForth.DoEncounter();
            }
        }
        else
        {
            if(!this.Third.IsDead)
            {
                Encounters.Encounter SecondVsThird= Encounters.EncounterFactory.GetEncounter(Encounters.EncounterType.Attack, this.First, this.Third);
                Console.WriteLine(SecondVsThird.ToString());
                SecondVsThird.DoEncounter();
            }
            else
            {
                Encounters.Encounter SecondVsForth= Encounters.EncounterFactory.GetEncounter(Encounters.EncounterType.Attack, this.Second, this.Forth);
                Console.WriteLine(SecondVsForth.ToString());
                SecondVsForth.DoEncounter();
            }
        }

    }
}