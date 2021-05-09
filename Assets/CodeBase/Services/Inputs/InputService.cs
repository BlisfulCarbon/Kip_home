using UnityEngine;

namespace CodeBase.Services.Inputs
{
    public abstract class InputService : IInputService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";
        private const string Button = "Fire";

        public abstract Vector2 Axis { get; }

        public bool isAttakButtonUp() 
            => SimpleInput.GetButton(Button);

        protected static Vector2 GetSimpleInputAxis() 
            => new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));
    }
}