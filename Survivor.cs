using System;

namespace ZombieSimulator
{
    public class Survivor
    {
        string name { get; set; }
        Weapon equippedWeapon { get; set; }
        public Survivor( string _name, Weapon _equippedWeapon)
        {
            this.name = _name;
            this.equippedWeapon = _equippedWeapon;
        }

        public string Name
        {
            get { return name; }
        }

        public Weapon Weapon
        {
            get { return equippedWeapon; }
            set { equippedWeapon = value; }
        }
    }
}