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
        [SerializeField] float speed;
        [SerializeField] MoveControl moveControl;
        

      
        void Update()
        {
            if (moveControl._directionEnum == DirectionEnum.Right)
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
                
            }
                
            else if (moveControl._directionEnum == DirectionEnum.Left)
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
            }
                
            else if (Input.GetKey(KeyCode.W))
                transform.position += Vector3.up * Time.deltaTime * speed;
        }
       
       
    }
}

