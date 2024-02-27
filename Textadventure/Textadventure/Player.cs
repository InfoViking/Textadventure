namespace Textadventure
{
    /// <summary>
    /// Player propertys
    /// </summary>
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

        /// <summary>
        /// Healthpoint Management
        /// </summary>
        /// <param name="healthpointsDifference"></param>
        internal void CalculateHealthpoints(int healthpointsDifference )
        {
            HealthPoints += healthpointsDifference;
            
            if ( HealthPoints <= 0 )
            {
                HealthPoints = 0;
                
            }
            else if ( HealthPoints > 20)
            {
                HealthPoints = 20;
            } 
        }

        /// <summary>
        /// DialoguePoints Management for Battle Class / Chapter 3
        /// </summary>
        /// <param name="dialoguepointsNumber"></param>
        internal void CalculateDialoguepoints(int dialoguepointsNumber)
        {
            DialoguePoints += dialoguepointsNumber;
        }

        /// <summary>
        /// query Rest/Drink
        /// </summary>
        internal void Rest()
        {
            const int healingRest = 5;
            CalculateHealthpoints(healingRest);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Die Rast tut deinen müden Knochen gut. Du regeneriest {healingRest} Healthpoints ");
            ConsoleText.Continue();

        }

        internal void UseEnergyDrink()
        {
            const int healingDrink = 10;
            CalculateHealthpoints(healingDrink);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Der Energydrink läuft deine Kehle hinunter. Du spürst wie er deinen Körper und Geist belebt. \n" +
                              $"Du regenerierst {healingDrink} Healthpoints ");
            
            HasEnergyDrink = false;
            ConsoleText.Continue();
        }
    }
}
