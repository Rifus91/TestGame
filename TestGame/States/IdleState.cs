using System;
using System.Collections.Generic;
using System.Text;

namespace TestGame.States
{
    public class IdleState : StateBase
    {
        public override StateType Execute(string command)
        {
            if (command == "1")
            {
                return StateType.Burn;
            } else if (command == "2")
            {
                return StateType.Heal;
            }

            return StateType.None;
        }

        protected override void RenderInternal()
        {
            Console.WriteLine($"Отдыхаю...{GameContext.Health}");
            Console.WriteLine("1) Обжечься (10)");
            Console.WriteLine("2) Полечиться");
        }
    }
}
