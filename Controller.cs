using System;

namespace ZombieSimulator
{
    public class Controller
    {

        public void deployChoice( SurvivorBase _survivorBase )
        {
            Console.WriteLine("What will you do next?");
            Console.WriteLine("==========================================");
            Console.WriteLine("1.Search for Weapons or supplies || 2.Repair Barricade || 3.Search for survivors || 4.Prepare for Night");
            Console.WriteLine("==========================================");
            
            int _screenedChoice = 0;
            string _choice = Console.ReadLine();

            try
            {
                _screenedChoice = Int32.Parse( _choice );
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine( "Please enter a number between 1 - 3" );
                deployChoice( _survivorBase );
                return;
            }

            switch( _screenedChoice )
            {
                case 1:
                    _survivorBase.search( _screenedChoice );
                    break;
                case 2:
                    _survivorBase.repair( _screenedChoice );
                    break;
                case 3:
                    Console.WriteLine("How many hours would you like to search?");
                    int _intHours = Int32.Parse(Console.ReadLine());
                    _survivorBase.searchForSurvivors( _intHours );
                    break;

            }

            if( _survivorBase.hoursRemaining > 0 )
            {
                Console.WriteLine($"{ _survivorBase.hoursRemaining } hours left until dark");
                deployChoice( _survivorBase );
            }
            else
            {
                Console.WriteLine("The night is here, time to man the barricade...");
            }
        }
    }
}