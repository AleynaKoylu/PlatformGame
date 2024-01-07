using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlatformGame.Scripts.Concretes.Move
{
    public class OnGround : MonoBehaviour
    {
        [SerializeField] Transform[] translates;
        [SerializeField] bool isOnGround = false;
        [SerializeField] float maxDistance=.15f;
        [SerializeField] LayerMask layerMask;
        public bool IsOnGround=>isOnGround;
        private void Update()
        {
            foreach (Transform ft in translates)
            {
                CheckFootOnGround(ft);
                if (isOnGround) break;
            }
        }

        private void CheckFootOnGround(Transform ft)
        {
            RaycastHit2D raycastHit2D=Physics2D.Raycast(ft.position,ft.forward,maxDistance,layerMask);
            Debug.DrawRay(ft.position, ft.forward * maxDistance, Color.red);
            if (raycastHit2D.collider != null)
            {
                isOnGround = true;
            }
            else
            {
                isOnGround=false;
            }
        }
    }
}

