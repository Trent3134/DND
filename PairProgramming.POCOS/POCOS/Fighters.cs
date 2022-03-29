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



    }
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
            _health = value;
        }

    }

    public void BroadSword(Dragon dragon)
    {
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 12)
        {
            System.Console.WriteLine("You need a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You swung the BroadSword");
            dragon.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon health: {dragon.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon!");
        }

    }

    public void FireBall(Dragon dragon)
    {
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
        else
        {
            System.Console.WriteLine("Sorry, you needed a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon!");
        }
    }
    public void ThunderBolt(Dragon dragon)
    {
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
        else
        {
            System.Console.WriteLine("Sorry, you needed a 11 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon!");
        }

    }

    public void LightingStrike(Dragon dragon)
    {
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
        else
        {
            System.Console.WriteLine("Sorry, you needed a 10 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon!");
        }
    }

    public void IceStorm(Dragon dragon)
    {
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
            System.Console.WriteLine($"the dragon Health: {dragon.Health}");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 8 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon!");
        }

    }

    public void BowAndArrow(Dragon dragon)
    {
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
            System.Console.WriteLine($"the dragon Health: {dragon.Health}");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon!");
        }
    }

    public void Potion(Fighters player)
    {
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
            System.Console.WriteLine($"you now have: {player.Health} Health!");

        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 16 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Potion could not be drank");
        }
    }


}
