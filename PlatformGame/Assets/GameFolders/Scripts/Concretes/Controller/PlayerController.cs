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
        Animator _animator;
        PlayerMove _playerMove;
        Rigidbody2D _rigidbody2D;
        PlayerJump _playerJump;
        PlayerScale _playerScale;
       
        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _playerMove = GetComponent<PlayerMove>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _playerJump = GetComponent<PlayerJump>();
            _playerScale = GetComponent<PlayerScale>();
        }

        private void Update()
        {
            _direction = moveControl.Direction;
            _isJump = moveControl.Jump;

            #region Silinecek
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right* speed * Time.deltaTime;
                _animator.SetFloat("Runtried", 1);

            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                _animator.SetFloat("Runtried", 1);

            }
            if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {
                _animator.SetFloat("Runtried", 0);

            }
            print(_rigidbody2D.velocity);
            #endregion
        }
        private void FixedUpdate()
        {
            _animator.SetFloat("Runtried", Mathf.Abs(_direction));

            _playerMove.MovePlayer(_direction);
            if (_direction != 0)
            {
               _playerScale.ScalePlayer(_direction);
            }
            if (_isJump)
            {
                _playerJump.JumpPlayer();
                
                _isJump = false;
                
            }
            _animator.SetBool("Jump", _playerJump.IsJumpAction);
        }
        
      

    }
}

