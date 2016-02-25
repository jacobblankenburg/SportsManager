using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class Player
    {
        Random rand = new Random();

        public string Name { get; set; }
        public int Number { get; set; }
        public string ShotDirection { get; set; }
        public string PlayerPosition { get; set; }
        public int Rating { get; set; }


        public Player(string name, int number, string shotdirection, string playerposition, int rating)
        {
            this.Name = name;
            this.Number = number;
            this.ShotDirection = shotdirection;
            this.PlayerPosition = playerposition;
            this.Rating = GivePlayerRandomRating();

        }
        public int GivePlayerRandomRating()
        {
            Rating = rand.Next(85, 99);
            return Rating;

        }
        public override string ToString()
        {
            return (Name + " has a number of : " + Number + ". shoots from the : " + ShotDirection + " side. " + Name + " is a : " + PlayerPosition + " and has a rating of " + Rating);
        } 
    }
}
