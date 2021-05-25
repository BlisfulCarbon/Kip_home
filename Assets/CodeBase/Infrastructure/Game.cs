using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public class Game
    {
        public static IInputService InputService;
        
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