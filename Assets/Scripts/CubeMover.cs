using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CubeMover : MonoBehaviour {
 
    public float moveTime = 0.5f;
 
    Vector3 startPosition;
    Vector3 targetPosition;
    float targetTime;
 
    void Start() {
        targetPosition = transform.position;
    }
 
    void Move(Vector3 move) {
 
        targetTime = Time.time + moveTime;
        startPosition = transform.position;
        targetPosition = transform.position + move;
 
        targetPosition.x = Mathf.Round(targetPosition.x);
        targetPosition.z = Mathf.Round(targetPosition.z);
 
    }
 
    void Update() {
 
        if(targetTime > Time.time) {
 
            transform.position = Vector3.Lerp(startPosition, targetPosition, 1 - (targetTime - Time.time) / moveTime);
 
        } else {
 
            transform.position = targetPosition;
 
            if(Input.GetKeyDown(KeyCode.UpArrow)) {
                Move(Vector3.forward);
            } else if(Input.GetKeyDown(KeyCode.DownArrow)) {
                Move(Vector3.back);
            } else if(Input.GetKeyDown(KeyCode.LeftArrow)) {
                Move(Vector3.left);
            } else if(Input.GetKeyDown(KeyCode.RightArrow)) {
                Move(Vector3.right);
            }
            
        }
 
    }
}