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

        public int Direction => _direction;
        public bool Jump => _jump;

        int _direction;
        bool _jump;


        ButtonSpriteChange _buttonSpriteChange;
        private void Awake()
        {
            _buttonSpriteChange = GetComponent<ButtonSpriteChange>();
        }
        public void LeftClick()
        {

            ButtonClick( 2, false);
            DirectionValue(-1);
        }
        public void RightClick()
        {

            ButtonClick( 1, false);
            DirectionValue(1);
        }
        public void UpClick()
        {

            ButtonClick( 0, false);
            DirectionValue(0);
        }
        public void JumpClick()
        {
            _jump = true;
            print("sl");

        }
       public void JumpUp()
        {
            _jump = false;
        }
        void ButtonClick( int index, bool jumpOrDirection)
        {
            if (jumpOrDirection)
                _buttonSpriteChange.SpriteChangeJump(index);
            else
                _buttonSpriteChange.SpriteChangeDirection(index);
            
        }
        void DirectionValue(int value)
        {
            _direction= value;
        }
      
    }
}

