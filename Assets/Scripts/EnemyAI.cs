using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Camera mainCamera;
    private NavMeshAgent agent;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            agent.SetDestination(target.position);
            //RaycastHit hit;
            //if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
            //{
            //    agent.SetDestination(hit.point);
            //}
        }
    }
}
