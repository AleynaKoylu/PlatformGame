using PlatformGame.Scripts.Concretes.Move;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Controller
{

    public class LadderController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnterExitOnTrigger(collision, 0, true);
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            EnterExitOnTrigger(collision, 1, false);
        }
        void EnterExitOnTrigger(Collider2D collider2D,int gravityScale,bool IsClimbing)
        {
            PlayerClimbed playerController =collider2D.GetComponent<PlayerClimbed>();
            if (playerController != null)
            {
                playerController.Rigidbody2D.gravityScale = gravityScale;
                playerController.IsClimbing = IsClimbing;
            }
        }
    }
}

