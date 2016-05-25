using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Contracts
{
    public interface IGame
    {
        void AddRoll(int pins);
        IFrame[] Frames { get; set; }
        int TotalScore();
        bool Over();
    }
}
