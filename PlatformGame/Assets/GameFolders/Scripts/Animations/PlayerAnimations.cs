using PlatformGame.Scripts.Concretes.Move;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.Animations
{
    [RequireComponent(typeof(Animator))]
    public class PlayerAnimations : MonoBehaviour
    {
        Animator _animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
        public void RunAnimation(float direciton)
        {
            float mathfValue=Mathf.Abs(direciton);
            if (_animator.GetFloat("Runtried") == mathfValue) return;
            _animator.SetFloat("Runtried", mathfValue);
        }
        public void JumpAnimation(bool jump)
        {
            if(jump== _animator.GetBool("Jump")) return;
            _animator.SetBool("Jump", jump);
        }

    }

}
