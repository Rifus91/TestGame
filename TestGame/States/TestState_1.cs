using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame.States
{
    public class TestState_1 : StateBase
    {
        public override StateType Execute(string command)
        {
            if (command == "1")
            {
                return StateType.Test1;
            } else if (command == "2")
            {
                return StateType.Test2;
            }

            return StateType.Test1;
        }

        protected override void RenderInternal()
        {
            Console.WriteLine("1) остаться в текущем состоянии");
            Console.WriteLine("2) сменить состояние");
        }
    }
}
