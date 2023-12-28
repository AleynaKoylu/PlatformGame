using PlatformGame.Scripts.Enum;
using PlatformGame.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Move
{
    public class PlayerMove : MonoBehaviour
    {
        public int IsRight { get { return _isRight; } }
        public int IsJump { get { return _isJump; } }
        int _isRight;
        int _isJump;
        [SerializeField] MoveControl moveControl;
        void Update()
        {
            switch (moveControl._directionEnum)
            {
                case DirectionEnum.Right:
                    Control(_isRight, 1);
                    break;
                case DirectionEnum.Left:
                    Control(_isRight,-1);
                    break;
                case DirectionEnum.Up:
                    Control(_isJump, 1);
                    break;
                case DirectionEnum.Down:
                    Control(_isJump,-1);
                    break;
                case DirectionEnum.Wait:
                    Control(_isJump,0);
                    Control(_isRight, 0);
                    break;
            }


            
           
        }

        void Control(int key, int value)
        {
            key = value;
        }

    }
}

