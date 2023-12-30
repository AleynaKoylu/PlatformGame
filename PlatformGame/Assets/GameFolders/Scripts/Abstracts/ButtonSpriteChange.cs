using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlatformGame.Scripts.Abstarct
{
    public class ButtonSpriteChange : MonoBehaviour
    {
        [SerializeField] List< Image> imageDirection;
        [SerializeField] List<Image> imageJump;
        public void SpriteChangeDirection(int imageIndex)
        {
            foreach (Image imageItem in imageDirection)
            {
                imageItem.gameObject.SetActive(false);
            }
            imageDirection[imageIndex].gameObject.SetActive(true);
        }
        public void SpriteChangeJump(int imageIndex)
        {
            foreach (Image imageItem in imageJump)
            {
                imageItem.gameObject.SetActive(false);
            }
            imageJump[imageIndex].gameObject.SetActive(true);
        }
    }

}
