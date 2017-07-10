using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

	//Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

	public float speed;

	public Rigidbody2D rigid;

	Animator anim;

	void Start() {
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Update(){
	
		if (Input.GetMouseButtonDown (0)) {
			anim.SetTrigger ("Attack");
		
		}

	}

	void FixedUpdate(){
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, 
			Vector3.forward);

		transform.rotation = rot;

		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		rigid.angularVelocity = 0f;
	

		float input = Input.GetAxis ("Vertical");
		rigid.AddForce (gameObject.transform.up * speed * input);


	}
}
