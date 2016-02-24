using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class Player
    {
        protected string Name;
        protected int Number;
        protected string ShotDirection;
        protected string PlayerPosition;
        protected bool IsHealthy;
        protected int Rating;


        public virtual void PlayerAction()
        {

        }
    }
}
