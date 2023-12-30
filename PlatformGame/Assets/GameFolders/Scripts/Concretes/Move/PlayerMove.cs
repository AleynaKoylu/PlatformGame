using PlatformGame.Scripts.Enum;
using PlatformGame.Scripts.UI;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Move
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] float speed;
        public void MovePlayer(float direction)
        {
            transform.Translate(Vector2.right * direction * Time.deltaTime * speed);
        }
    }
}

