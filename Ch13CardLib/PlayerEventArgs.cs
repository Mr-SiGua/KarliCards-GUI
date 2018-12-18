using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch13CardLib
{
    public class PlayerEventArgs : EventArgs
    {
        public Player Player
        {
            get => default(int);
            set
            {
            }
        }

        public PlayerState State
        {
            get => default(int);
            set
            {
            }
        }
    }
}