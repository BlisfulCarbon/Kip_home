using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;

        public BootstrapState(GameStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public void Enter()
        {
            RegisterService();
        }
        
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