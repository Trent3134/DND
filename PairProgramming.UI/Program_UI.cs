using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Program_UI
{
    Fighters player = new Fighters();
    Dragon dragon = new Dragon();
    public void run()
    {
        // SeedData();

        RunApplication();
    }

    private void RunApplication()
    {
        bool isRunning = true;
        bool isGameStarted = false;
        while (isRunning)
        {
            System.Console.WriteLine("welcome to the BattleGround");
            System.Console.WriteLine("Press any key to start");
            isGameStarted = true;
            if (isGameStarted && player.Health > 0)
            {
                FighterSetUpMenu();
                System.Console.WriteLine("You have wondered deep into the forbiden forest and start walking your way around it. All the sudden you have noticed a flying DRAGON come upon you, and the only way out is to defeat the BEAST");
                PressAnyKeyToContinue();
                bool FightHasStarted = true; 
                while (FightHasStarted && player.Health > 0 && ( dragon.Health > 0)) 
                {
                    Console.Clear();
                    playerAttackMenu(dragon);
                    DragonAttacks(player);
                }
            }
        }
    }

    private void FighterSetUpMenu()
    {
        System.Console.WriteLine("--- Fighter Menu---");
        System.Console.WriteLine("--- What is your name: ");
        player.Name = Console.ReadLine();
        System.Console.WriteLine($"Hi {player.Name}, Level: {player.Level}");
        PressAnyKeyToContinue();
    }

    private  void playerAttackMenu(Dragon dragon)
    {
        {
            System.Console.WriteLine("Please make a selection \n" +
            "Depending on roll will determine if it is a sucessfull attack! \n" + 
            "1. BroadSword -- 10 Damage \n" +
            "2. FireBall -- 25 Damage \n"  +
            "3. ThunderBold -- 20 Damage \n" +
            "4. LightingStrike -- 30 Damage \n" +
            "5. IceStorm -- 16 Damage \n" +
            "6. BowAndArrow-- 40 Damage \n" +
            "7. Shield Potion-- +25Hp");
            var userSelection = int.Parse(System.Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    player.BroadSword(dragon);
                    break;
                    case 2: 
                    player.FireBall(dragon);
                    break;
                    case 3: 
                    player.ThunderBolt(dragon);
                    break;
                    case 4: 
                    player.LightingStrike(dragon);
                    break;
                    case 5: 
                    player.IceStorm(dragon);
                    break;
                    case 6: 
                    player.BowAndArrow(dragon);
                    break;
                    case 7: 
                    player.Potion(player);
                    break;
                default:
                    System.Console.WriteLine("invalid selection");
                    break;
            }
            PressAnyKeyToContinue();
        }
    }

    private void PressAnyKeyToContinue()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("press any key to continue");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }

    private void DragonAttacks(Fighters player)
    {
        {
            // System.Console.WriteLine("Please make a selection \n" +
            // "1. Bite \n" +
            // "2. Claw \n" +
            // "3. Tail \n" +
            // "4. FireBreath \n" +
            // "5. WingAttack \n");
            var number = Radomizer.GetRandomNumber(1, 6);
            switch (number)
            {
                case 1:
                    dragon.Bite(player);
                    break;
                    case 2: 
                    dragon.Claw(player);
                    break;
                    case 3: 
                    dragon.Tail(player);
                    break;
                    case 4: 
                    dragon.FireBreath(player);
                    break;
                    case 5: 
                    dragon.WingAttack(player);
                    break;
                default:
                    System.Console.WriteLine("invalid selection");
                    break;
            }
            PressAnyKeyToContinue();

        }
    }

    private void SeedData()
    {
        throw new NotImplementedException();
    }
}
