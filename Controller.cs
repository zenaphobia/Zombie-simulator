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
            switch( _choice )
            {
                case "1" or "Search":
                    _typedChoice = int.Parse(Console.ReadLine());
                    _survivorBase.search(_typedChoice);
                    break;
                case "2" or "repair":
                    _typedChoice = int.Parse(Console.ReadLine());
                    _survivorBase.repair(_typedChoice);
                    break;
            }
        }
    }
}