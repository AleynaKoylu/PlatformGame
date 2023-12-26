using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlatformGame.Scripts.Abstarct
{
    public abstract class ButtonSpriteChange : MonoBehaviour
    {
        [SerializeField] List <Sprite> sprites = new List<Sprite>();
        [SerializeField] Image image;
        public void SpriteChangee(int index)
        {
            image.sprite = sprites[index];
        }
    }

}
