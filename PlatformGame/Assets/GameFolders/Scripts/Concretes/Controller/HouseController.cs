using PlatformGame.Scripts.Concretes.Controller.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Controller
{
    public class HouseController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            PlayerController playerController = collision.GetComponent<PlayerController>();
            if (playerController != null)
            {
                GameManager.Instance.LoadScene();
            }
        }
    }

}
