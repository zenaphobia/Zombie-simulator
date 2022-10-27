using System;

namespace ZombieSimulator
{
    public class WeaponGenerator
    {
        public Weapon getWeapon( string _weapon )
        {
            switch( _weapon )
            {
                case "pistol":
                    return new Weapon( "Pistol", 2 );
                case "rifle":
                    return new Weapon( "Hunting rifle", 6);
                case "ar":
                    return new Weapon( "Fully-automatic rifle", 10 );
                case "unarmed":
                    return new Weapon("Unarmed", 1);
                default:
                    Console.WriteLine( "Error generating weapon, spawning pistol" );
                    return new Weapon( "Pistol", 2 );
            }
        }
    }
}