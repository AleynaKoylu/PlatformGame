using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlatformGame.Scripts.Abstarct
{
    public class ButtonSpriteChange : MonoBehaviour
    {
        [SerializeField] List< Image> image;

        public void SpriteChangee(int imageIndex)
        {
           
            image[imageIndex].gameObject.SetActive(true);
        }
    }

}
