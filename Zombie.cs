using System;

namespace ZombieSimulator
{
    public class Zombie
    {
        string Type {get; set;}
        int Damage {get; set;}
        int Amount { get; set; }

        public Zombie(string _type, int _damage, int _amount)
        {
            this.Type = _type;
            this.Damage = _damage;
            this.Amount = _amount;
        }

        public int damage
        {
            get { return Damage ;}
        }

        public string type
        {
            get { return Type; }
        }

        public int amount
        {
            get { return Amount; }

            set
            {
                this.Amount = value;
            }
        }

        public void addZombie( int _amount )
        {
            this.amount += _amount;
        }

        public void removeZombie( int _amount )
        {
            if( _amount > this.amount )
            {
                Console.WriteLine("Error, removing too many zombies.");
                return;
            }
            this.amount -= _amount;
        }
    }
}