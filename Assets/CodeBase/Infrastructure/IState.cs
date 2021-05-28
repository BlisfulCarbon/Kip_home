using UnityEditor;

namespace CodeBase.Infrastructure.Main
{
    public interface IState
    {
        void Enter();
        
        void Exit();
    }
}