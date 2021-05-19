using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "ObjectMusuh"){
			Debug.Log("Collide");
			AudioSource aud = gameObject.GetComponent<AudioSource>();
			aud.Play();
			col.gameObject.SetActive(false);
		}
	}
}
