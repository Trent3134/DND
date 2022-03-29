using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Dragon
{
    public Dragon() { }

    public Dragon(string name, int health)
    {
        Name = name;
        Health = health;

    }

    private int _health = 400;
    public string Name { get; set; }

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
                System.Console.WriteLine("Dragon has DIED!!!");
            }
            _health = value;
        }
    }

    public void Bite(Fighters player)
    {
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 7)
        {
            System.Console.WriteLine("Dragon needed a 7 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has bit you");
            player.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you lost 10 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"your health is at:  {player.Health}");

        }
        else
        {
            System.Console.WriteLine("Dragon needs a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has missed you!!");
        }

    }

    public void Claw(Fighters player)
    {
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 11)
        {
            System.Console.WriteLine("Dragon needed a 11 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has clawwed you!!");
            player.Health -= 15;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you lost 15 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"your health is at:  {player.Health}");
        }
        else
        {
            System.Console.WriteLine("Dragon needs a 15  or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has missed you!!");
        }

    }

    public void Tail(Fighters player)
    {
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 14)
        {
            System.Console.WriteLine("Dragon needed a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has Tailed you");
            player.Health -= 22;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you lost 22 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"your health is at:  {player.Health}");
        }
        else
        {System.Console.WriteLine("Dragon needs a 14 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has missed you!!");
        }
    }

    public void FireBreath(Fighters player)
    {
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 15)
        {
            System.Console.WriteLine("Dragon needed a 15 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has used Firebreath on you");
            player.Health -= 30;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you lost 30 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"your health is at:  {player.Health}");
        }
        else
        {
            System.Console.WriteLine("Dragon needs a 15 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has missed you!!");
        }
    }

    public void WingAttack(Fighters player)
    {
        var number = Radomizer.GetRandomNumber(1, 21);
        if (number >= 12)
        {
            System.Console.WriteLine("Dragon needed a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has hit you with a wing attack");
            player.Health -= 25;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("you lost 25 health");
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"your health is at:  {player.Health}");
        }
        else
        {
            System.Console.WriteLine("Dragon needs a 12 or higher");
            System.Console.WriteLine($"roll is: {number}");
            System.Console.WriteLine("Dragon has missed you!!");
        }
    }

}
