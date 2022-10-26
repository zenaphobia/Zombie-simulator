using System;

namespace ZombieSimulator
{
    class ZombieSimulator
    {
        static void Main(string[] args)
        {
            string userInput;
            int daysSurvived = 0;

            ZombieEngine zombieEngine = new ZombieEngine();
            Animation animation = new Animation();
            SurvivorBase homeBase = new SurvivorBase( 45, 82 );

            // Spawning zombies !BRAINZ!
            Zombie strayZombie = zombieEngine.spawnZombie( "stray", 3 );
            Zombie titanZombie = zombieEngine.spawnZombie( "titan", 2 );
            zombieEngine.addZombieToWave(strayZombie);

            //Spawning survivors and beginning equipment
            Weapon pistol = new Weapon( "Pistol", 2 );
            Survivor mainSurvivor = new Survivor( "Alex", pistol );
            homeBase.addSurvivor( mainSurvivor );

            animation.animateText("Dusk is setting, you must prepare yourself for another wave...");
            animation.pause();
            animation.animateText($"You find shelter and barricade it as best you can... Your base is at { homeBase.BaseHealth }");
            animation.animateText("You hear them coming...");

            animation.animateText($"The undead deal { zombieEngine.getTotalDamage() - homeBase.getTotalDefense() }");
            homeBase.BaseHealth = homeBase.BaseHealth - zombieEngine.getTotalDamage();

            animation.animateText( $"Your base is at { homeBase.BaseHealth }" );

            Console.WriteLine("What will you do next?");

            Console.WriteLine("==========================================");
            Console.WriteLine("1.Search for Weapons or supplies || 2.Repair Barricade || 3.Search for survivors");
            Console.WriteLine("==========================================");

            userInput = Console.ReadLine();

            search();
        }

        public void search()
        {

        }
    }
}