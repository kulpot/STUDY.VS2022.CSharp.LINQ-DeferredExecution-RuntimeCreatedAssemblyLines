using System;
using System.Collections.Generic;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=6g1C7wEOmIU&list=PL90AF0EFFEF782D27&index=13&t=1s
// Assembly Line Chain - yield statement 

static class MainClass
{
    
    static void Main()
    {
        int[] stuff = { 4, 13, 8, 1, 9 };
        /*IEnumerable<int> result1 = stuff;
        for(int j = 0; j < 3; j++)
        {
            if (RandomBool)
                result1 = result1.Where(i => i < 8);
            if (RandomBool)
                result1 = result1.Where(i => i > 2);
            if (RandomBool)
                result1 = result1.Select(i => i * 2);
            if (RandomBool)
                result1 = result1.Select(i => i + 9);
        }*/
        IEnumerable<int> result1 = stuff.Where(i => i < 8);
        var result2 = result1.Where(i =>i > 2).Select(i => i * 2 + 9);
        var result3 = result1.OrderBy(i => i).Select(i => i % 7).Where(i => i < 20);
    }
    /*static Random rand = new Random();
    static bool RandomBool
    {
        get { return rand.Next() % 2 == 0; }
    }*/
}