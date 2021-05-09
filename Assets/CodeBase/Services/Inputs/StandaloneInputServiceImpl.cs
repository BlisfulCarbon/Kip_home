using UnityEngine;

namespace CodeBase.Services.Inputs
{
    public class StandaloneInputServiceImpl : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                Vector2 axis = GetSimpleInputAxis();

                if (axis == Vector2.zero)
                    UnityAxis();

                return axis;
            }
        }

        private static void UnityAxis() => new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
    }
}