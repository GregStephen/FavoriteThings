using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{ 
    enum LiquorType
    {
        Whiskey,
        Bourbon,
        Scotch,
        Tequila,
        Vodka,
        Gin,
    }
    class Liquor
    {
        public int _fullness = 100;
        public int _shotAmount = 5;
        public LiquorType _typeOfLiquor;
        public Liquor(LiquorType typeOfLiquor)
        {
            _typeOfLiquor = typeOfLiquor;
        }

        public void PourSingleShot()
        {
            if (_fullness < _shotAmount)
            {
                Console.WriteLine("Bruh, the bottle is empty");
                return;
            }
            if (_typeOfLiquor == LiquorType.Gin)
            {
                Console.WriteLine("Get that shit outta here");
                return;
            }
            if (_typeOfLiquor == LiquorType.Scotch || _typeOfLiquor == LiquorType.Bourbon || _typeOfLiquor == LiquorType.Whiskey)
            {
                Console.WriteLine($"You gotta pour a double of that {_typeOfLiquor}, I'm sorry");
                _fullness -= (_shotAmount * 2);
            }
            else
            {
                Console.WriteLine("This shit better be chilled, at least");
                _fullness -= _shotAmount;
            }
        }

        public void MakeADrink()
        {
            if (_fullness < (_shotAmount * 2))
            {
                Console.WriteLine("Bruh, buy a new bottle");
                return;
            }
            Console.WriteLine("THAT WAS DELICIOUS THANK YOU");
            _fullness -= (_shotAmount * 2);
        }

    }
}
