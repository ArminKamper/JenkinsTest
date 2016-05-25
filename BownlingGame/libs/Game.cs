using BowlingGame.Contracts;
using System;
using System.Collections.Generic;

namespace BowlingGame.libs
{
    public class Game : IGame
    {
        int round;

        public Game()
        {
            Frames = new IFrame[10];
            round = 0;
        }

        public void AddRoll(int pins)
        {
            IFrame activeFrame = Frames[round];
            if (activeFrame == null)
            {
                activeFrame = new Frame();
                activeFrame.PinsRolled[0] = pins;
                Frames[round] = activeFrame;
            }
            else
            {
                activeFrame.PinsRolled[1] = pins;
            }
            activeFrame.Punktezahl += pins;
        }

        public bool Over()
        {
            throw new NotImplementedException();
        }

        public int TotalScore()
        {
            throw new NotImplementedException();
        }

        public IFrame[] Frames { get; set; }
    }
}
