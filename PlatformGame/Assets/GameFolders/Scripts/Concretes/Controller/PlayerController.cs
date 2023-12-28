using PlatformGame.Scripts.Concretes.Move;
using PlatformGame.Scripts.Enum;
using PlatformGame.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlatformGame.Scripts.Concretes.Controller
{
    public class PlayerController : MonoBehaviour
    {
        PlayerMove _playerMove;
        [SerializeField] float speed;
        SpriteRenderer _spriteRenderer;
        Animator animator;
        private void Awake()
        {
            _playerMove = GetComponent<PlayerMove>();
            _spriteRenderer = transform.GetComponentInChildren<SpriteRenderer>();
            animator = GetComponent<Animator>();
        }
        private void FixedUpdate()
        {
            if (_playerMove.IsRight == 1)
            {
                Move(Vector3.right, false, true);
            }
            else if (_playerMove.IsRight == -1)
            {
                Move(Vector3.left, true, true);
            }
            else if (_playerMove.IsRight == 0)
            {
                Move(Vector3.left, true, true);
            }
            else if (_playerMove.IsJump == 1)
            {
                Jump(Vector3.up, true, "Jump");
            }
            else if (_playerMove.IsJump == -1)
            {
                JumpAnimControl(true,"Down");
            }
            else
            {
                AnimControl(false);
                JumpAnimControl(false, "Jump");
                JumpAnimControl(false, "Down");
            }
                
            if (Input.GetKeyDown(KeyCode.W))
            {
                Jump(Vector3.up, true, "Jump");
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                JumpAnimControl(true, "Down");
            }
            else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.W))
            {
                JumpAnimControl(false, "Jump");
                JumpAnimControl(false, "Down");
            }
        }
        void Move(Vector3 direction,bool directionFlip,bool runAnim)
        {
            transform.position += direction * Time.deltaTime * speed;
            _spriteRenderer.flipX = directionFlip;
            AnimControl(runAnim);
        }
        void AnimControl(bool runAnim)
        {
            if (runAnim)
            {
                animator.SetBool("Run", true);
            }
            else
            {
                animator.SetBool("Run", false);
            }
        }
        void Jump(Vector3 direction, bool runAnim,string animName)
        {
            transform.position += direction * Time.deltaTime * speed;
           JumpAnimControl(runAnim,animName);
        }
        void JumpAnimControl(bool jumpAnim,string animName)
        {

            if (jumpAnim)
            {
                animator.SetBool(animName, true);
            }
            else
            {
                animator.SetBool(animName, false);
            }
        }
    }
}

