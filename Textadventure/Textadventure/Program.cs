﻿using Textadventure;

/// <summary>
/// Entrypoint of application
/// </summary>
public static class Program
{
    public static void Main()
    {
        Titlescreen.StartingScreen();

        Player player = Prologue.Character();

        Prologue prologue = new Prologue(player);
        prologue.CharacterDetails(player.Name);
        prologue.Intro();

        Chapter1 chapter1 = new Chapter1(player);
        chapter1.Beginning();

        Chapter2 chapter2 = new Chapter2(player);
        chapter2.Beginning();

        Chapter3 chapter3 = new Chapter3(player);
        chapter3.Beginning();
        chapter3.Camp();
        chapter3.BattleDailogueOpening();

        Battle battle = new Battle(player);
        battle.BattleDialogue1();
        battle.BattleDialogue2();
        battle.BattleDialogue3();
        battle.BattleDialogue4();
        battle.Dialogueresult();
        
        Epilogue epilogue = new Epilogue(player);
        epilogue.Beginning();
    }
}


