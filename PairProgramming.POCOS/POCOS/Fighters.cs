using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Fighters 
{
    public Fighters() { }

    public Fighters(string name, string weapon, int level, int health)
    {
        Name = name;
        Weapon = weapon;
        Level = level;
        Health = health;
        WizardNPC = new Wizard();
    }
    public Wizard WizardNPC  { get; set; }
    private int _health = 200;
    public int ID { get; set; }
    public string Name { get; set; }
    public string Weapon { get; set; }
    public int Level { get; set; }=5;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value <= 0)
            {
                _health = 0;
                System.Console.WriteLine("You just DIED!!!");
            }
            else if (value <= 100)
            {
                _health = 100;
                System.Console.WriteLine("I would take a health Potion");
            }
            _health = value;
        }

    }

    public void BroadSword(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 12)
        {
            System.Console.WriteLine("You need a 12 or higher" );
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You swung the BroadSword");
            dragon.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon health: {dragon.Health} ");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Sword has hit the barrier and cut you");
            player.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }

    }

    public void FireBall(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 12)
        {
            System.Console.WriteLine("You need a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("you used FireBall Attack");
            dragon.Health -= 25;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 25 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon health: {dragon.Health}");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your spell has backfired");
            player.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }
    }
    public void ThunderBolt(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 11)
        {
            System.Console.WriteLine("You need a 11 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("you used ThunderBolt");
            dragon.Health -= 20;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 20 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon Health: {dragon.Health}");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Spell has backfired");
            player.Health -= 12;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 12 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 11 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }

    }

    public void LightingStrike(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 10)
        {
            System.Console.WriteLine("You need a 10 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("you used a LightingStrike!!");
            dragon.Health -= 30;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 30 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon Health: {dragon.Health}");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Spell has backfired");
            player.Health -= 11;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 11 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 10 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }
    }

    public void IceStorm(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 8)
        {
            System.Console.WriteLine("You need a 8 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("you used IceStorm");
            dragon.Health -= 16;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 16 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon Health: {dragon.Health} \n");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Spell has backfired");
            player.Health -= 6;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 6 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} \n");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 8 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }

    }

    public void BowAndArrow(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 14)
        {
            System.Console.WriteLine("You need a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("you used BowAndArrow");
            dragon.Health -= 40;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you lost 40 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon Health: {dragon.Health} \n");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Bow and Arrow was Fire incorrectly and came back and hit you");
            player.Health -= 12;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 12 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} \n ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }
    }

    public void DeathStrike(Dragon dragon, Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 20)
        {
            System.Console.WriteLine("You need a 20 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You just used DEATHSTRIKE");
            dragon.Health -= 80;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon has Lost 80 Health!!!");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"Dragon has {dragon.Health} Health! \n");

        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Spell has backfired");
            player.Health -= 20;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you have lost 12 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {player.Name} health: {player.Health} \n ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 20 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You missed the dragon! \n");
        }
        
    }

    public void Potion(Fighters player)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >=16)
        {
            System.Console.WriteLine("You need a 16 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("you just drank a +25 HP potion!");
            player.Health += 25;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("you Gained 25 Health!");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"you now have: {player.Health} Health! \n");

        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 16 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Potion could not be drank \n");
        }
    }


}
