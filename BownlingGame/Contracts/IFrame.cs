using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame.Contracts
{
    public interface IFrame
    {
        int[] PinsRolled { get; set; }
        int Punktezahl { get; set; }


    }
}
