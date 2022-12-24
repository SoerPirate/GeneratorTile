using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GunController : MonoBehaviour {

	public Transform weaponHold;

	public GameObject PrefabContainer;
	public Gun prefabGun;
	//public Gun startingGun;

	public Gun equippedGun;

	//public GameObject equippedGun;

	void Start() 
	{
		//var wpnHLD = GameObject.FindGameObjectWithTag("WeaponHold"); gameObject 
		//var wpnHLD = transform.GetChild(1); 
		//weaponHold = wpnHLD.Transform;

		//prefabGun = GameObject.Find("Gun") as Gun; 

		PrefabContainer = GameObject.Find("PrefabContainer");

		var PrefabScript = PrefabContainer.GetComponent<PrefabScript>(); 

		prefabGun = PrefabScript.gun;// as Gun;

		//prefabGun = Resources.Load("Gun") as Gun;

		weaponHold = transform.GetChild(1); 

		equippedGun = Instantiate(prefabGun, weaponHold.position, weaponHold.rotation) as Gun;
		equippedGun.transform.parent = weaponHold;

		//equippedGun.transform.Rotate(0.0f, 90.0f, 90.0f);
		equippedGun.transform.localPosition = new Vector3 (0, 0, 1);
		equippedGun.transform.localRotation = Quaternion.Euler(0, 90, 90);
		
		var ProjectileSpawn = equippedGun.transform.GetChild(0);
		
		//ProjectileSpawn.transform.Rotate(270.0f, 0.0f, 90.0f);
		ProjectileSpawn.transform.localPosition = new Vector3 (0, 1, 0);
		ProjectileSpawn.transform.localRotation = Quaternion.Euler(270, 0, 90);
 	}


	public void Shoot() {
		if (equippedGun != null) {
			equippedGun.Shoot();
		}
	}
}