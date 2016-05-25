using BowlingGame.Contracts;
using System;

namespace BowlingGame.libs
{
    public class Frame : IFrame
    {
        public Frame()
        {
            PinsRolled = new int[2];
            PinsRolled[0] = -1;
            PinsRolled[1] = -1;
        }

        public int[] PinsRolled{ get; set; }

        public int Punktezahl{ get; set; }
    }
}
