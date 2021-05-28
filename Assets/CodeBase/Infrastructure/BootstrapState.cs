using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public class BootstrapState : IState
    {
        private const string Initial = "Initial";
        private readonly GameStateMachine _stateMachine;
        private SceneLoader _sceneLoader;

        public BootstrapState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            RegisterService();
            _sceneLoader.Load(Initial, EnterLoadLevel);
        }

        private void EnterLoadLevel() => 
            _stateMachine.Enter<LoadLevelState>();

        public void Exit()
        {
            
        }
        
        private void RegisterService()
        {
            Game.InputService = RegisterInputService();
        }

        private InputService RegisterInputService()
        {
            if (Application.isEditor)
                return new StandaloneInputServiceImpl();
            else
                return new MobileInputServiceImpl();
        }
    }
}