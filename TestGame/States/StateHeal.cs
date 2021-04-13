using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame.States
{
    public class StateHeal : StateBase
    {
        public override StateType Execute(string command)
        {
            GameContext.SetHealth(GameContext.Health + 100);
            return StateType.Idle;
        }

        protected override void RenderInternal()
        {
            Console.WriteLine("Как хорошо, как новенький!");
        }
    }
}
