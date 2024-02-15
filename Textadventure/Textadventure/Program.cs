using Textadventure;

public static class Adventure
{
    public static void Main()
    {
        Titlescreen.StartingScreen();
        Console.ReadLine();

        Player player = Prologue.Character();
        Console.ReadLine();

        Prologue prologue = new Prologue(player);
        prologue.Intro();

        Chapter1 chapter1 = new Chapter1(player);
        chapter1.Beginning();

        Chapter2 chapter2 = new Chapter2(player);
        chapter2.Beginning();
        

        
        
        
        


    }
}


