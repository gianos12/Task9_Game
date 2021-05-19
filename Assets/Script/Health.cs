using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	[SerializeField]
	int _maximunHealth = 100;
	int _currentHelath = 0;

	// Use this for initialization
	void Start () {
		_currentHelath = _maximunHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Damage(int damageValue){
		_currentHelath -= damageValue;
		if (_currentHelath<=0) {
			Destroy(gameObject);
		}
	}
}
