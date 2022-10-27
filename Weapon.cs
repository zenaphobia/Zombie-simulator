using System;

namespace ZombieSimulator
{
    public class Weapon
    {
        string name { get; set; }
        int damage { get; set; }

        public Weapon( string _name, int _damage )
        {
            this.name = _name;
            this.damage = _damage;
        }

        public string Name
        {
            get { return name; }
        }

        public int Damage
        {
            get { return damage; }
        }


    }
}