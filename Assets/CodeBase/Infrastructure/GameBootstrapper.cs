using UnityEngine;

namespace CodeBase.Infrastructure.Main
{
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game();
            
            DontDestroyOnLoad(this);
        }
    }
}