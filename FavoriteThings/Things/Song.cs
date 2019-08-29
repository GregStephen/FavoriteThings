using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Song
    { 
        public string Name { get; set; }
        public int Length { get; set; }

        public int _volume;

        public int _maxVolume = 100;

        public bool _isPlaying;


   
        public Song(string name, int length)
        {
            Name = name;
            Length = length;
        }

        public void Play()
        {
            if (!_isPlaying)
            {
                Console.WriteLine($"{Name} is playing");
                _isPlaying = true;
            }
            else
            {
                Console.WriteLine($"{Name} is already playing, ya goof");
            }
        }

        public void Stop()
        {
            if (_isPlaying)
            {
                Console.WriteLine($"{Name} has stopped");
                _isPlaying = false;
            }
            else
            {
                Console.WriteLine("Nothing is playing");
            }
            
        }

        public void TurnUp()
        {
            if (_volume < _maxVolume)
            {
                _volume += 5;
                Console.WriteLine($"{Name} has turned up to {_volume}");
            }
            else
            {
                Console.WriteLine("Turn this shit down");
            }
        }

        public void TurnDown()
        {
            if (_volume > 5)
            {
                _volume -= 5;
                Console.WriteLine($"{Name} has turned down to {_volume}");
            }
            else
            {
                Console.WriteLine($"{Name} is already down as low as can be, maybe just stop the song champ");
            }
        }
    }
}
