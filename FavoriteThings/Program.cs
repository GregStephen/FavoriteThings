
using System;
using FavoriteThings.Things;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = new Song("For Free?", 250);
            song.Play();
            song.TurnUp();

            var song2 = new Song("Goin' Against Your Mind", 320);
            song2.Play();
            song2.Stop();

            var game = new VidyaGame("Planet Coaster", "Management");
            game.Play();
            game.Play();
            game.Play();
            game.Save();
            game.Play();
            game.Quit();

            var game2 = new VidyaGame("Skyrim", "Adventure");
            game2.Play();
            game2.Play();
            game2.Quit();

            var liquor = new Liquor(LiquorType.Scotch);
            liquor.PourSingleShot();
            liquor.MakeADrink();

            var liquor2 = new Liquor(LiquorType.Gin);
            liquor2.PourSingleShot();

            var tallulah = new Kid("Tallulah", 2);
            var emory = new Kid("Emory", 7);

            tallulah.PlayWith(TypeOfPlay.Monster);
            tallulah.PlayWith(TypeOfPlay.Reading);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.PlayWith(TypeOfPlay.Wrestling);
            emory.Feed(TypeOfFood.Meal);
            emory.PutDown(TypeOfSleep.Nap);
        }
    }
}
