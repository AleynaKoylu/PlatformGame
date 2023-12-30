using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Move
{
    public class PlayerScale : MonoBehaviour
    {
        public void ScalePlayer(float direction)
        {
            transform.localScale = new Vector3(Mathf.Sign(direction), 1, 1);
        }
        
    }

}
