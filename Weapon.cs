using System;

namespace ZombieSimulator
{
    public class Weapon
    {
        string name { get; set; }
        int damage { get; set; }

        public Weapon(string _name, int _damage)
        {
            this.name = _name;
            this.damage = _damage;
        }

        public Weapon getWeapon(string _weapon)
        {
            switch(_weapon)
            {
                case "pistol":
                    return new Weapon("Pistol", 2);
                default:
                    Console.WriteLine("Error generating weapon, spawning pistol");
                    return new Weapon("Pistol", 2);
            }
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