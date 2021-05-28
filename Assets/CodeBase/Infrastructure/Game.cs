using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public class Game
    {
        public static InputService InputService;
        public GameStateMachine StateMachine;

        public  Game()
        {
            StateMachine = new GameStateMachine();
        }
    }
}