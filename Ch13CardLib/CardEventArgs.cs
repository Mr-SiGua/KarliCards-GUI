using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch13CardLib
{
    public class CardEventArgs : EventArgs
    {
        public Card Card
        {
            get;
            set;
        }
    }
}