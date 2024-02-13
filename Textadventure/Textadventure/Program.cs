using Textadventure;

public static class Adventure
{
    public static void Main()
    {
        Titlescreen.StartingScreen();
        Console.ReadLine();

        Prologue.Character();
        Console.ReadLine();

        Prologue.Intro();
        Console.ReadLine();

        Chapter1.Beginning();
        Console.ReadLine();
        
        Player player = new Player();
        player.Name = "Hännschen";
        
        DecisionChapter1 decisionChapter1 = new DecisionChapter1(player);
        decisionChapter1.Decision();


    }
}


