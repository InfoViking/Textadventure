namespace Textadventure
{
    internal class Player
    {
       internal int HealthPoints { get; private set; }
       internal int DialoguePoints { get; private set; }
       internal string Name {  get; set; }
       internal int Age {  get; set; }
       internal int Height {  get; set; }
       internal bool IsGoatMaster { get; set; } 
        
        internal bool HasEnergyDrink {  get; set; }
        

        

        
        


        internal Player()
        {
            HealthPoints = 20;
            DialoguePoints = 0;
            HasEnergyDrink = true;
            IsGoatMaster = false;
            
        }

        internal void CalculateHealthpoints(int healthpointsDifference )
        {
            HealthPoints += healthpointsDifference;
            
            if ( HealthPoints < 0 )
            {
                HealthPoints = 0;
            }
            else if ( HealthPoints > 20)
            {
                HealthPoints = 20;
            } 
            else if ( HealthPoints <= 0)
            {
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
                Titlescreen.StartingScreen();

            }
            
        }

        internal void CalculateDialoguepoints(int dialoguepointsNumber)
        {
            DialoguePoints += dialoguepointsNumber;
        }

        internal void Rest()
        {
            const int healingRest = 5;
            CalculateHealthpoints(healingRest);
            Console.WriteLine($"Die Rast tat deinen müden Knochen gut. Du regeneriest {healingRest} Healthpoints ");


        }

        internal void UseEnergyDrink()
        {
            
            const int healingDrink = 10;
            CalculateHealthpoints(healingDrink);
            Console.WriteLine($"Der Energydrink läuft deine Kehle hinunter. Du spürst wie er deinen Körper und Geist belebt. \n" +
                              $"Du regenerierst {healingDrink} Healthpoints ");

            HasEnergyDrink = false;
        }









    }
}
