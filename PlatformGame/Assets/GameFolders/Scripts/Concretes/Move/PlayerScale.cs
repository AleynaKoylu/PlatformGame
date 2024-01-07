using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Move
{
    public class PlayerScale : MonoBehaviour
    {
        public void ScalePlayer(float direction)
        {
            if (direction != 0)
            {
                float mathfValue = Mathf.Sin(direction);
                if (transform.localScale.x == mathfValue) return;
                transform.localScale = new Vector3(mathfValue, 1, 1);
            }
            
        }
        
    }

}
