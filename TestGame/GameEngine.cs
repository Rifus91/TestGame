using System;
using System.Collections.Generic;
using System.Text;
using TestGame.States;

namespace TestGame
{
    public class GameEngine
    {
        private StateBase currentState;
        Dictionary<StateType, StateBase> states = new Dictionary<StateType, StateBase>();
        GameContext gameContext;

        public GameEngine()
        {
            //states.Add(StateType.Test1, new TestState_1());
            //states.Add(StateType.Test2, new TestState_2());
            states.Add(StateType.Burn, new StateBurn());
            states.Add(StateType.Idle, new IdleState());
        }

        //states.Add(StateType.Test1, new State());
        //StateBase state = states[StateType.Test1];

        public void StartGame(StateType startState)
        {
            gameContext = new GameContext(50);
            foreach (StateBase state in states.Values)
            {
                state.SetGameContext(gameContext);
            }

            currentState = states[startState];
            while (true)
            {
                currentState.Render();
                string command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }

                StateType newState = currentState.Execute(command);
                if (newState == StateType.None)
                {
                    continue;
                }

                if (!states.ContainsKey(newState))
                {
                    Console.WriteLine("Beda");
                    Console.Read();
                    break;
                }

                currentState = states[newState];
            }
        }

    }
}
