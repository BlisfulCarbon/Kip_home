using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public IInputService InputService;
        
        public  Game()
        {
            RegisterInputService();
        }

        private void RegisterInputService()
        {
            if (Application.isEditor)
                InputService = new StandaloneInputServiceImpl();
            else
                InputService = new MobileInputServiceImpl();
        }
    }
}