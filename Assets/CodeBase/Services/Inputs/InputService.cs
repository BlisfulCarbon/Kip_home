using UnityEngine;

namespace CodeBase.Services.Inputs
{
    public abstract class InputService : IInputService
    {
        public const string Horizontal = "Horizontal";
        public const string Vertical = "Vertical";
        public const string Button = "Fire";

        public abstract Vector2 Axis { get; }
        
        public bool IsAttackButtonUp() =>
            SimpleInput.GetButtonUp(Button);

        protected static Vector2 SimpleInputAxis() =>
            new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}