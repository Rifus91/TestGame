using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame.States
{
    public class StateBurn : StateBase
    {
        public override StateType Execute(string command)
        {
            GameContext.SetHealth(GameContext.Health - 10);
            return StateType.Idle;
        }

        protected override void RenderInternal()
        {
            Console.WriteLine("ай я обжёгся");
        }
    }
}
