using PlatformGame.Scripts.Abstarct;
using PlatformGame.Scripts.Concretes.Move;
using PlatformGame.Scripts.Enum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.UI
{
    public class MoveControl : ButtonSpriteChange
    {
        public DirectionEnum _directionEnum { get { return _direction; } set { _direction = value; } }
        [SerializeField] DirectionEnum _direction;
        [SerializeField] Animator animator;

        public void LeftClick()
        {
          
            DownClick(DirectionEnum.Left,1,true);
        }
        public void RightClick()
        {
            
            DownClick(DirectionEnum.Right,2,true);
        }
        public void UpClick()
        {
            
            DownClick(DirectionEnum.Wait,0, false);
        }
        public void JumpClick()
        {
            DownClick(DirectionEnum.Up, 3,false);
        }
        void DownClick(DirectionEnum directionEnum,int index,bool runAnim)
        {
           
           SpriteChangee(index);
           _direction = directionEnum;
            if(runAnim) 
            {
                animator.SetBool("Run", true);
            }
            else
            {
                animator.SetBool("Run", false);
            }
        }

    }
}

