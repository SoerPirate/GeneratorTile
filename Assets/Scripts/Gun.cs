using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gun : MonoBehaviour {

	public Transform muzzle;
	public Projectile projectile;
	public float msBetweenShots = 700; // 100
	public float muzzleVelocity = 5; // 35

	float nextShotTime;

	public void Shoot() {

		if (Time.time > nextShotTime) {
			nextShotTime = Time.time + msBetweenShots / 1000;
			Projectile newProjectile = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
			newProjectile.SetSpeed (muzzleVelocity);
		}
	}
}
