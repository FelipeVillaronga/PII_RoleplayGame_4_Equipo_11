using System.Collections.Generic;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
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
        this.CharactersList= new List<Character> () {this.First, this.Second, this.Third, this.Forth};
        this.FirstVsSecond= EncounterFactory.GetEncounter(EncounterType.Attack, this.First, this.Second);
        this.ThirdVsForth= EncounterFactory.GetEncounter(EncounterType.Attack, this.Third, this.Forth);
    }
    private Character first {get; set;}
    private Character second {get; set;}
    private Character third {get; set;}
    private Character forth {get; set;}

    public Character First {get; set;}
    public Character Second {get; set;}
    public Character Third {get; set;}
    public Character Forth {get; set;}

    public Encounter FirstVsSecond {get; set;}
    public Encounter ThirdVsForth {get; set;}
    public Encounter Winners {get; set;}
    public List<Character> CharactersList {get; set;}
    public void Setup()
    {
        foreach(Character character in CharactersList)
        {
            character.CleanItem();
        }
        CharactersList[0].AddItems(new List<IItem> () {new MagicWand(), new PowerGlove()});
        CharactersList[1].AddItems(new List<IItem> () {new Stick(), new Robes()});
        CharactersList[2].AddItems(new List<IItem> () {new Breastplate(), new ChainMail()});
        CharactersList[3].AddItems(new List<IItem> () {new Dagger(), new MagicWand()});
    }
    public void Run()
    {   
        Console.WriteLine(FirstVsSecond.ToString());
        FirstVsSecond.DoEncounter();
        Console.WriteLine(ThirdVsForth.ToString());
        ThirdVsForth.DoEncounter();
        Survivors();
    }
    public void Survivors()
    {
        if(!this.First.IsDead)
        {
            if(!this.Third.IsDead)
            {
                this.Winners= EncounterFactory.GetEncounter(EncounterType.Attack, this.First, this.Third);
            }
            else
            {
                this.Winners= EncounterFactory.GetEncounter(EncounterType.Attack, this.First, this.Forth);
            }
        }
        else
        {
            if(!this.Third.IsDead)
            {
                this.Winners= EncounterFactory.GetEncounter(EncounterType.Attack, this.First, this.Third);
            }
            else
            {
                this.Winners= EncounterFactory.GetEncounter(EncounterType.Attack, this.Second, this.Forth);
            }
        }
    }

    public void Finale()
    {
        Console.WriteLine(this.Winners.ToString());
        this.Winners.DoEncounter();
    }
}