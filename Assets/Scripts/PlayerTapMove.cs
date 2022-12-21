using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Photon;
using Photon.Pun;
//using Cinemachine;

public class PlayerTapMove : MonoBehaviour
{
    public Camera mainCamera;
    private NavMeshAgent agent;
    PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        photonView = gameObject.GetComponent<PhotonView>();
        //playerName = photonView.Owner.NickName;
        //gameObject.name = playerName;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (photonView.IsMine)
        {
        if (Input.GetMouseButtonDown(0)) 
            {
                RaycastHit hit;
                if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
        
    }
}
