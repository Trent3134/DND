using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Wizard 
{
    public Wizard() { }

    public Wizard(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }

    public int _health = 150;
    public string Name { get; set; }
    public int Level { get; set; } = 6;
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
                System.Console.WriteLine("Wizard just DIED!!!");
            }
            else if (value <= 100)
            {
                _health = 100;
                System.Console.WriteLine("I would take a health Potion");
            }
            _health = value;
        }

    }

    public void FireBolt(Dragon dragon, Wizard wizard)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 15)
        {
            System.Console.WriteLine("You need a 15 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You swung the BroadSword");
            dragon.Health -= 20;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 20 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon health: {dragon.Health} ");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your FireBolt has backfired");
            wizard.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("wizard has lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {wizard.Name} health: {wizard.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, you needed a 15 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }
    }

    public void MagicMissle(Dragon dragon, Wizard wizard)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 14)
        {
            System.Console.WriteLine("You need a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Wizard Fired a MagicMissle");
            dragon.Health -= 25;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 25 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon health: {dragon.Health} ");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your MagicMissle has backfired");
            wizard.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("wizard has lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {wizard.Name} health: {wizard.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, Wizard needed a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }
    }

    public void FlamingSphere(Dragon dragon, Wizard wizard)
    {
        System.Threading.Thread.Sleep(500);
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 17)
        {
            System.Console.WriteLine("You need a 17 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You swung the BroadSword");
            dragon.Health -= 30;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Dragon lost 30 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"the dragon health: {dragon.Health} ");
        }
        else if (number <= 1)
        {
            System.Console.WriteLine("You just rolled a crit 1");
            System.Console.WriteLine($"roll is {number}");
            System.Console.WriteLine("your Spell has backfired");
            wizard.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("wizard has lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($" {wizard.Name} health: {wizard.Health} ");
        }
        else
        {
            System.Console.WriteLine("Sorry, Wizard needed a 17 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("You have missed the Dragon! \n");
        }
    }
    public void MarkOfHealthing(Wizard wizard)
    {
        System.Threading.Thread.Sleep(500);
          var number = Radomizer.GetRandomNumber(1, 21);
        if (number >=14)
        {
            System.Console.WriteLine("You need a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Wizard just used spell +25 HP potion!");
            wizard.Health += 25;
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("you Gained 25 Health!");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"you now have: {wizard.Health} Health!");
        }
        
        else
        {
            System.Console.WriteLine("Sorry, you needed a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Spell could not be cast \n");
        }  
    }
}
