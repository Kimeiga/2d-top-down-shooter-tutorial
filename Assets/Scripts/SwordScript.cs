using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

	public GameObject explosion;

	void OnTriggerEnter2D(Collider2D other){
	
		Instantiate (explosion, other.transform.position, Quaternion.identity);

		Destroy (other.gameObject);
	}
}
