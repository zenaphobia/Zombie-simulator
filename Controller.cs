using System;

namespace ZombieSimulator
{
    public class Controller
    {
        public Controller()
        {

        }

        public int search(int _time)
        {
            int _random;
            Random randomGenerator = new Random();

            _random = randomGenerator.Next(0,100);

            switch(_random)
            {
                case <= 25:
                    return 5;
                    break;
            }

            return 0;
        }
    }
}