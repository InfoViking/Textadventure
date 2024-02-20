namespace Textadventure
{
    internal class Player
    {
       internal int HealthPoints { get; private set; }
       internal string Name {  get; set; }
       internal int Age {  get; set; }
        internal int Height {  get; set; }
        internal bool IsGoatMaster { get; set; } = false;
        

        
        


        internal Player()
        {
            HealthPoints = 20;
        }

        internal void CalculateHealthpoints(int healthpointsDifference )
        {//to do: Game Over Screen
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

        internal void Rest(int healingRest = 5)
        {
            CalculateHealthpoints(healingRest);
            Console.WriteLine($"Die Rast tat deinen müden Knochen gut. Du regeneriest {healingRest} Healthpoints ");


        }

        internal void DrinkEnergy(int healingDrink = 15)
        {
            CalculateHealthpoints(healingDrink);
            Console.WriteLine($"Der Energydrink läuft deine Kehle hinunter. Du spürst wie er deinen Körper und Geist belebt. " +
                              $"Du regenerierst {healingDrink} Healthpoints ");


        }





    }
}
