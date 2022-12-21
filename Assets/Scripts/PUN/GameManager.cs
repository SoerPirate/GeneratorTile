/*
 * Copyright (c) 2019 Razeware LLC
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * Notwithstanding the foregoing, you may not use, copy, modify, merge, publish, 
 * distribute, sublicense, create a derivative work, and/or sell copies of the 
 * Software in any work that is designed, intended, or marketed for pedagogical or 
 * instructional purposes related to programming, coding, application development, 
 * or information technology.  Permission for such use, copying, modification,
 * merger, publication, distribution, sublicensing, creation of derivative works, 
 * or sale is expressly withheld.
 *    
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;
using System.Collections.Generic;

//using Cinemachine;

using Photon.Realtime;

namespace Photon.Pun.Demo.PunBasics
{
    public class GameManager : MonoBehaviourPunCallbacks
    {
        //public GameObject winnerUI;

        public GameObject player1SpawnPosition;
        public GameObject player2SpawnPosition;

        //public CinemachineVirtualCamera cinemachineCamera;

        //public GameObject ballSpawnTransform;

        private GameObject ball;
        private GameObject player1;
        private GameObject player2;

        // Start Method
        void Start()
        {
            if (!PhotonNetwork.IsConnected) // 1
            {
                SceneManager.LoadScene("Launcher");
                return;
            }

            //if (PlayerManager.LocalPlayerInstance == null)
            //{
                //if (PhotonNetwork.IsMasterClient) // 2
                //{
            Debug.Log("Instantiating Player 1");
                    // 3
            var player1 = PhotonNetwork.Instantiate("Player", player1SpawnPosition.transform.position, player1SpawnPosition.transform.rotation, 0);
            player1.AddComponent<PlayerTapMove>(); 
            player1.AddComponent<FieldOfView>();          
            player1.AddComponent<Controller>();   

            // GameObject vcgo = new GameObject();

            // vcgo.transform.position = new Vector3(0, 25, 0);
            // vcgo.transform.Rotate(90.0f, 0.0f, 0.0f);

            // cinemachineCamera = vcgo.AddComponent<CinemachineVirtualCamera>();

            // cinemachineCamera.Follow = player1.transform;
            // cinemachineCamera.LookAt = player1.transform;
            // cinemachineCamera.m_Lens.OrthographicSize = 20;
            // cinemachineCamera.m_Lens.NearClipPlane = 0;
            // cinemachineCamera.m_Lens.FarClipPlane = 30;





            //var pltmove = player1.GetComponent<PlayerTapMove>(); 
            //pltmove.mainCamera = cinemachineCamera; 

                    // 4
                    //ball = PhotonNetwork.Instantiate("Ball", ballSpawnTransform.transform.position, ballSpawnTransform.transform.rotation, 0);
                    //ball.name = "Ball";
                //}
                //else // 5
                //{
                //Debug.Log("Instantiating Player 2");
                //var player2 = PhotonNetwork.Instantiate("Player", player2SpawnPosition.transform.position, player2SpawnPosition.transform.rotation, 0);
                //player2.AddComponent<PlayerTapMove>(); 
                //player2.AddComponent<FieldOfView>();          
                //player2.AddComponent<Controller>(); 

                    //cinemachineCamera.Follow = player2.transform;
                    //cinemachineCamera.LookAt = player2.transform;
                //}
            //}
        }

        // Update Method
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) //1
            {
                Application.Quit();
            }
        }

        // Photon Methods
        //public override void OnPlayerLeftRoom(Player other)
        public void OnPlayerLeftRoom(Player other)
        {
            //Debug.Log("OnPlayerLeftRoom() " + other.NickName); // seen when other disconnects
            Debug.Log("OnPlayerLeftRoom() ");
            if (PhotonNetwork.IsMasterClient)
            {
                PhotonNetwork.LoadLevel("Launcher");
            }
        }

        // Helper Methods
        public void QuitRoom()
        {
            Application.Quit();
        }
    }
}
