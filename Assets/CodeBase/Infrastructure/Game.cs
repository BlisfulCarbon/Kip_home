using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public class Game
    {
        public static InputService InputService;
        public GameStateMachine StateMachine;

        public Game(ICoroutineRunner coroutineRunner)
        {
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner));
        }
    }
}