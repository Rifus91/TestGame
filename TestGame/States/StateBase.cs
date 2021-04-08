using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame.States
{
    public abstract class StateBase
    {
        protected GameContext GameContext;

        public void SetGameContext(GameContext gameContext)
        {
            GameContext = gameContext;
        }

        public void Render() 
        {
            Console.Clear();
            Console.WriteLine($"== {GetType()}");
            RenderInternal();
            Console.WriteLine("==");
        }

        protected abstract void RenderInternal();

        public abstract StateType Execute(string command);

        
    }
}
