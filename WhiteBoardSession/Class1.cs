using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardSession
{
    internal class Class1
    {
        // given a string.
        // check if it contains a unique characters.
        // return is boolean.
        // hello   ____
        // string != char
        // word = Helo
        // check = "Helogjfliuyfyflflfvlfvjgvjgvjg X 100000"

        public bool IsUnique(string word)
        {
            var check = word.ToCharArray();///
            Array.Sort(check);
            for (int i = 0; i < check.Length; i++)
            {
                if(i < check.Length - 1 && check[i] == check[i + 1])
                {
                    return false;
                }
            }
            return true; 
        }

        public Dictionary<string, int> GetChipCount(int amount)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if(amount >= 100)
            {
                var remainder = amount % 100;
                var for100 = amount - remainder;
                var countFor100 = for100 / 100;
                result.Add("100", countFor100); 
                amount -= for100;
            }
            if(amount >= 50)
            {
                var remainder = amount % 50;
                var for50 = amount - remainder;
                var countFor50 = for50 / 50;
                result.Add("50", countFor50);
                amount -= for50;
            }
            if(amount >= 25)
            {
                var remainder = amount % 25;
                var for25 = amount - remainder;
                var countFor25 = for25 / 25;
                result.Add("25", countFor25);
                amount -= for25;
            }
            if(amount >= 10)
            {
                var remainder = amount % 10;
                var for10 = amount - remainder;
                var countFor10 = for10 / 10;
                result.Add("10", countFor10);
                amount -= for10;
            }
            if(amount >= 5)
            {
                var remainder = amount % 5;
                var for5 = amount - remainder;
                var countFor5 = for5 / 5;
                result.Add("5", countFor5);
                amount -= for5;
            }
            if(amount >= 1)
            {
                var remainder = amount % 1;
                var for1 = amount - remainder;
                var countFor1 = for1 / 1;
                result.Add("1", countFor1);
                amount -= for1;
            }
            return result;
        }
    }
}
