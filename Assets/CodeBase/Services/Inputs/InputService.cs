﻿using UnityEngine;

namespace CodeBase.Services.Inputs
{
    class InputService : IInputService
    {
        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private const string Button = "Fire";

        public Vector2 Axis => new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));

        public bool isAttakButtonUp() => SimpleInput.GetButton(Button);
    }
}