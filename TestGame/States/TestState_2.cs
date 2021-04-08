using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame.States
{
    public class TestState_2 : StateBase
    {
        public override StateType Execute(string command)
        {
            if (command == "3")
            {
                return StateType.Test2;
            }
            else if (command == "4")
            {
                return StateType.Test1;
            }

            return StateType.Test2;
        }

        protected override void RenderInternal()
        {
            Console.WriteLine("3) остаться в текущем состоянии");
            Console.WriteLine("4) сменить состояние");
        }
    }
}
