using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  
    
        Rigidbody wheelRB;
        private void Start()
        {
            if (GameObject.Find("wheel").GetComponent<Rigidbody>() == null)
            {
                GameObject.Find("wheel").AddComponent<Rigidbody>();
            }
            wheelRB = GameObject.Find("wheel").GetComponent<Rigidbody>();
            wheelRB.useGravity = false;
        }
        void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                wheelRB.MoveRotation(wheelRB.rotation * Quaternion.Euler(0, 0, 1));
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                wheelRB.MoveRotation(wheelRB.rotation * Quaternion.Euler(0, 0, -1));
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
                wheelRB.rotation = Quaternion.identity;
            }
        }
   
}

