using System;
using CodeBase.CameraLogic;
using CodeBase.Infrastructure.Main;
using CodeBase.Services.Inputs;
using UnityEngine;

namespace CodeBase.Hero
{
    public class HeroMove : MonoBehaviour
    {
        public CharacterController CharacterController;
        
        public float MovementSpeed;
        private InputService _inputService;
        private Camera _camera;

        private void Awake()
        {
            _inputService = Game.InputService;
        }

        private void Start()
        {
            _camera = Camera.main;

            CameraFollow();
        }

        private void Update()
        {
            Vector3 movementVector = Vector3.zero;

            if (_inputService.Axis.sqrMagnitude > GameConstants.Epsilon)
            {
                var axis = _inputService.Axis;
                movementVector = _camera.transform.TransformDirection(axis.x, 0 ,axis.y);

                movementVector.y = 0;
                movementVector.Normalize();

                transform.forward = movementVector;

                movementVector += Physics.gravity;
            }

            CharacterController.Move(MovementSpeed * movementVector * Time.deltaTime);
        }

        private void CameraFollow() => 
            _camera.GetComponent<CameraFollow>().Follow(this.gameObject);
    }
}