using System;
using System.Collections.Generic;

namespace TestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameEngine().StartGame(States.StateType.Idle);
        
        }
    }
}
