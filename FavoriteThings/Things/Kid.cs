using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    enum TypeOfPlay {
        Monster,
        Reading,
        Coloring,
        Wrestling
    }

    enum TypeOfFood
    {
        Snack,
        Meal
    }

    enum TypeOfSleep
    {
        Nap,
        DeepSleep
    }
    class Kid
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int _weariness;
        public int _hunger;

        int _levelOfHungerResultingInTantrum = 80;
        int _levelOfWearinessResultingInTantrum = 85;
        int _alotOfFun = 30;
        int _relaxingFun = 10;
        int _snack = 15;
        int _meal = 40;
        int _nap = 20;
        int _deepSleep = 100;

        public Kid(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Tantrum()
        {
            Console.WriteLine("OH GOD EVERYTHING IS THE WORST WHY THE FUCK GOD DAMN IT ALL");
        }
        public void PlayWith(TypeOfPlay playType)
        {
            if (_weariness > _levelOfWearinessResultingInTantrum || _hunger > _levelOfHungerResultingInTantrum)
            {
                Tantrum();
                return;
            }
            if (playType == TypeOfPlay.Monster || playType == TypeOfPlay.Wrestling)
            {
                Console.WriteLine("You are the king of this domain, your wife yells at everyone to stop screaming and calm down");
                _weariness += _alotOfFun;
                _hunger += _alotOfFun;
            }
            else if (playType == TypeOfPlay.Reading)
            {
                Console.WriteLine("The rain is coming down slowly outside and you two snuggle up and read together");
                _weariness += _relaxingFun;
                _hunger += _relaxingFun;
            }
            else if (playType == TypeOfPlay.Coloring)
            {
                Console.WriteLine("Markers come off the walls right?");
                _weariness += _relaxingFun;
                _hunger += _relaxingFun;
            }

        }

        public void Feed(TypeOfFood food)
        {
            if (_hunger < 25)
            {
                Console.WriteLine($"{Name} is not hungry at all, stop contributing to childhood obesity");
                return;
            }
            if (food == TypeOfFood.Snack)
            {
                Console.WriteLine($"{Name} loved those fruit snacks!");
                _hunger -= _snack;
                if (_hunger < 0)
                {
                    _hunger = 0;
                }
            }
            else if (food == TypeOfFood.Meal)
            {
                Console.WriteLine($"{Name} insisted on mini corn dogs...again.");
                _hunger -= _meal;
                if (_hunger < 0)
                {
                    _hunger = 0;
                }
            }
        }

        public void PutDown(TypeOfSleep sleep)
        {
            if (_weariness < 25)
            {
                Console.WriteLine($"{Name} isn't tired and is wondering why you wouldn't rather play?");
            }
            else if (sleep == TypeOfSleep.Nap)
            {
                Console.WriteLine($"{Name} fought it mildly but is out for about an hour, go play a vidya game");
                _weariness -= _nap;
                if (_weariness < 0)
                {
                    _weariness = 0;
                }
            }
            else if (sleep == TypeOfSleep.DeepSleep)
            {
                Console.WriteLine($"{Name} is down for the night, go make yourself a drink");
                _weariness -= _deepSleep;
                if (_weariness < 0)
                {
                    _weariness = 0;
                }
            }

        }
    }
}
