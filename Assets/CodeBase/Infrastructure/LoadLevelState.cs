using System;

namespace CodeBase.Infrastructure.Main
{
    public class LoadLevelState : IState
    {
        private const string SceneNameDevelop = "Develop";
        private GameStateMachine _gameStateMachine;
        private SceneLoader _sceneLoader;
        
        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.Load(SceneNameDevelop);
        }

        public void Exit()
        {
            
        }
    }
}