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
            
        }

        
        


    }
}
