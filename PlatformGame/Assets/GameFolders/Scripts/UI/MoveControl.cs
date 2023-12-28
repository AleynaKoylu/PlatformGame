using PlatformGame.Scripts.Abstarct;
using PlatformGame.Scripts.Concretes.Move;
using PlatformGame.Scripts.Enum;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace PlatformGame.Scripts.UI
{
    public class MoveControl : MonoBehaviour
    {
        public DirectionEnum _directionEnum { get { return _direction; } set { _direction = value; } }
        [SerializeField] DirectionEnum _direction;
        ButtonSpriteChange _buttonSpriteChange;
        private void Awake()
        {
            _buttonSpriteChange = GetComponent<ButtonSpriteChange>();
        }
        public void LeftClick()
        {
          
            ButtonClick(DirectionEnum.Left,1);
        }
        public void RightClick()
        {
            
            ButtonClick(DirectionEnum.Right,2);
        }
        public void UpClick()
        {
            
            ButtonClick(DirectionEnum.Wait,0);

            ButtonClick(DirectionEnum.Wait, 3);
        }
        public void JumpClick()
        {
            ButtonClick(DirectionEnum.Up, 4);
        }
        public void DownClick()
        {
            ButtonClick(DirectionEnum.Up, 5);
        }
        private void Update()
        {
            if (Input.GetKey(KeyCode.S))
            {
                DownClick();
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                UpClick();
            }
        }
        void ButtonClick(DirectionEnum directionEnum,int index)
        {
           
          _buttonSpriteChange.SpriteChangee(index);
           _direction = directionEnum;
        }

    }
}

