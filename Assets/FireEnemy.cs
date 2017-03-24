using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour {
	//the bullet prefab
	public GameObject bullet;

	//the firing for initialization
	public float interval =2;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Fire", interval, interval);
	}

	void Fire()
	{
		//Spawn the bullet
		GameObject g = (GameObject)Instantiate(bullet,transform.position,
		Quaternion.identity);

		//Ignore Bullet<->Enemy Ship collisions
		Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
			transform.parent.GetComponent<Collider2D>());


	}
	

}
