using UnityEngine;
using System.Collections;
using Photon;
using Photon.Pun;

public class Controller : MonoBehaviour {

	public float moveSpeed = 6;

	//Rigidbody rigidbody;
	Camera viewCamera;
	Vector3 velocity;
	PhotonView photonView;

	void Start () {
		//rigidbody = GetComponent<Rigidbody> ();
		//PhotonView photonView;
		photonView = gameObject.GetComponent<PhotonView>();
		viewCamera = Camera.main;
	}

	void Update () 
	{
		if (photonView.IsMine)
		{
			Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
			transform.LookAt (mousePos + Vector3.up * transform.position.y);

			velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * moveSpeed;
		}

		//velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * moveSpeed;
	}

	//void FixedUpdate() {
		//rigidbody.MovePosition (rigidbody.position + velocity * Time.fixedDeltaTime);
	//}
}