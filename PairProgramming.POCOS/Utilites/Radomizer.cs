using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public static class Radomizer
{
    public static int GetRandomNumber(int inclusive, int exclusive)
    {
        Random rand = new Random();
        int number = rand.Next(inclusive, exclusive);
        return number;
    }
}
