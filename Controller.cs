using System;

namespace ZombieSimulator
{
    public class Controller
    {
        public Controller()
        {

        }

        public void deployChoice( string _choice, SurvivorBase _survivorBase )
        {
            int _typedChoice;
            _typedChoice = int.Parse(Console.ReadLine());
            switch( _choice )
            {
                case "1" or "Search":
                    _survivorBase.search(_typedChoice);
                    break;
                case "2" or "repair":
                    _survivorBase.repair(_typedChoice);
                    break;
                case "3":
                    int _intHours = int.Parse(Console.ReadLine());
                    _survivorBase.searchForSurvivors( _intHours );
                    break;

            }
        }
    }
}