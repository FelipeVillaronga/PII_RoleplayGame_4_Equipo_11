using System.Collections.Generic;
using RoleplayGame.Characters;

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
            character.Items= new List<Items.IItem> () {};
        }
    }
    public void Run()
    {
        Encounters.EncounterType FirstVsSecond= Encounters.EncounterFactory.GetEncounter(1, )
    }
}