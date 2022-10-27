using System;
using System.Collections;
using System.Collections.Generic;

namespace ZombieSimulator
{
    public class ZombieEngine
    {
        int strayTotal { get; set; }
        int titanTotal { get; set; }
        int sprinterTotal { get; set; }
        List<Zombie> zombieList = new List<Zombie>();
        public Zombie spawnZombie( string zombie_type, int _amount )
        {
            switch(zombie_type)
            {
                case "stray":
                    return new Zombie( "Stray", 2, _amount );
                case "titan":
                    return new Zombie( "Titan", 10 , _amount );
                case "sprinter":
                    return new Zombie( "Sprinter", 4, _amount );
            }
            Console.WriteLine("Error spawning Zombie, spawning Stray");
            return new Zombie("Stray", 2, 1);
        }
        public void addZombieToWave( Zombie _zombie )
        {
            zombieList.Add( _zombie );
        }

        public List<Zombie> allZombies
        {
            get { return zombieList; }
        }

        public int getTotalDamage()
        {
            int _total = 0;
            int _sectionTotal = 0;

            foreach( Zombie zombie in zombieList )
            {
                _sectionTotal += zombie.damage * zombie.amount;
                //Console.WriteLine($"Section total is { _sectionTotal }");
                _total += _sectionTotal;
                //Console.WriteLine($"Total damage is currently at { _total }");
            }
            //Console.WriteLine($"returned total was { _total }");
            return _total;
        }
    }
}