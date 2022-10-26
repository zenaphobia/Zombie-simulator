using System;

namespace ZombieSimulator
{
    public class SurvivorBase
    {
        int baseHealth { get; set; }
        int maxHealth { get; set; }
        int dayTimeRemaining { get; set; }
        List<Survivor> allSurvivors = new List<Survivor>();
        public SurvivorBase( int _baseHealth, int _maxHealth )
        {
            this.baseHealth = _baseHealth;
            this.maxHealth = _maxHealth;
            this.dayTimeRemaining = 12;
        }

        public void repair(int _hours)
        {
            if(hoursRemaining <= 0)
            {
                Console.WriteLine("No time remaining");
                return;
            }
            if(_hours > hoursRemaining)
            {
                Console.WriteLine("Not enough time remaining...");
                return;
            }

        }

        public int getTotalDefense()
        {
            int _totalDefense = 0;
            int _sectionDefense = 0;

            foreach( Survivor survivor in allSurvivors )
            {
                _sectionDefense += survivor.getWeapon.Damage;
                _totalDefense += _sectionDefense;
            }

            return _totalDefense;
        }

        public void addSurvivor(Survivor _survivor)
        {
            allSurvivors.Add(_survivor);
        }

        public void removeSurvivor(Survivor _survivor)
        {
            allSurvivors.Remove(_survivor);
        }

        public int search(int _time)
        {

            Random randomInt100 = new Random();
            double _random = randomInt100.NextDouble();

            switch( _random * _time )
            {
                case < .25:
                    return 5;
                case < .50:
                    return 9;
                case < .80:
                    return 14;
                case < .99:
                    return 22;
                case .99:
                    return 25;
            }
            //needs to return something...
            return 0;
        }

        public int hoursRemaining
        {
            get { return dayTimeRemaining; }
        }

        public int BaseHealth
        {
            get { return baseHealth; }
            set { baseHealth = value; }

        }
    }
}