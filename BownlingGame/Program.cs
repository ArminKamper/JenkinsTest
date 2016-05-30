using BowlingGame.libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame.Contracts;
using Autofac;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<Game>().As<IGame>();

            IGame game = cb.Build().Resolve<IGame>();
            game.AddRoll(4);

            
        }
    }
}
