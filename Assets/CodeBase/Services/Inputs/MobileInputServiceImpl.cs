using UnityEngine;

namespace CodeBase.Services.Inputs
{
    public class MobileInputServiceImpl : InputService
    {
        public override Vector2 Axis => GetSimpleInputAxis();
    }
}