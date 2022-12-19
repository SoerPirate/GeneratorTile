/**********************************************************/
/** 	© 2018 NULLcode Studio. All Rights Reserved.
/** 	Разработано в рамках проекта: https://null-code.ru/
/** 	Помощь проекту - Яндекс.Деньги: 410011769316504
/**********************************************************/

using UnityEngine;
using System.Collections;

public class NaviControl : MonoBehaviour {

	public float speedMove = 5;
	public float speedRotation = 2;

	void Update()
	{
		if(!MouseNavi.isDone || MouseNavi.path.Count == 0 || MouseNavi.index >= MouseNavi.path.Count) return;
		transform.position = Vector3.MoveTowards(transform.position, MouseNavi.path[MouseNavi.index].position, speedMove * Time.deltaTime);
		transform.forward = Vector3.MoveTowards(transform.forward, MouseNavi.direction, speedRotation * Time.deltaTime);
	}
}
