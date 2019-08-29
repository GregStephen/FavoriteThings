using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class VidyaGame
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public bool _savedSincePlayed;
        public int _progressSinceLastSave;
        public int _progress;

        public VidyaGame(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }

        public void Play()
        {
            if (_progress == 100)
            {
                Console.WriteLine("You've beaten the game already! Play something else for a bit");
            }
            else
            {
                _progressSinceLastSave += 5;
                _savedSincePlayed = false;
                Console.WriteLine($"You are {_progress + _progressSinceLastSave}% thru playing {Title}");
                Console.WriteLine("Don't forget to save your progress before you quit!");
            }
        }

        public void Save()
        {
            _progress += _progressSinceLastSave;
            _savedSincePlayed = true;
            _progressSinceLastSave = 0;
        }

        public void Quit()
        {
            if (!_savedSincePlayed)
            {
                Console.WriteLine($"You forgot to save and lost {_progressSinceLastSave}% of your progress! Ya dummy");
                _progressSinceLastSave = 0;
            }
        }
    }
}
