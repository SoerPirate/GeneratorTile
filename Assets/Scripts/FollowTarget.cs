using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



//namespace UnityStandardAssets.Utility
//{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);


        private void Update()
        {
            transform.position = target.position + offset;
        }
    }
//}
