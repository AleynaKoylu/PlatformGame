using PlatformGame.Scripts.Animations;
using PlatformGame.Scripts.Concretes.Move;
using PlatformGame.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlatformGame.Scripts.Concretes.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float speed;
        
        [SerializeField] MoveControl moveControl;
       

        float _direction;
        bool _isJump;
       
        PlayerMove _playerMove;
        PlayerJump _playerJump;
        PlayerScale _playerScale;
        PlayerAnimations _playerAnimations;
        OnGround _onGround;

        private void Awake()
        {
           
            _playerMove = GetComponent<PlayerMove>();
            _playerJump = GetComponent<PlayerJump>();
            _playerScale = GetComponent<PlayerScale>();
            _playerAnimations= GetComponent<PlayerAnimations>();
            _onGround = GetComponent<OnGround>();
        }

        private void Update()
        {
            _direction = moveControl.Direction;
            if (moveControl.Jump == true && _onGround.IsOnGround == true)
                _isJump = true;
            else
                _isJump = false;
            

            #region Silinecek
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right* speed * Time.deltaTime;
                _playerAnimations.RunAnimation(1);

            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                _playerAnimations.RunAnimation(1);

            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {
                _playerAnimations.RunAnimation(0);

            }
           
            #endregion
        }
        private void FixedUpdate()
        {
            _playerAnimations.RunAnimation(_direction);
            _playerMove.MovePlayer(_direction);
            _playerScale.ScalePlayer(_direction);
            _playerJump.JumpPlayer(_isJump);
            _playerAnimations.JumpAnimation(_playerJump.IsJumpAction);
        }
        
      

    }
}

