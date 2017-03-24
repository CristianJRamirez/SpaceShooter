using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		//collided with a ship? then destroy it.
		if (coll.gameObject.tag=="ship")
			Destroy(coll.gameObject);

		//Destroy Bullet in any case
		Destroy(gameObject);	
	}
}
