using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {
	Animation _animation;

	// Use this for initialization
	void Start () {
		_animation = GetComponentInChildren<Animation> ();
		_animation.SyncLayer (0);
	}
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxisRaw ("Vertical");
		float h = Input.GetAxisRaw ("Horizontal");
		bool runningForward = v > 0;
		bool runningBackward = v < 0;
		bool notRunningForwardOrBackward = v == 0;
		bool runnigForwardOrStanding = v >= 0;
		bool runningLeft = h < 0;
		bool runnigRight = h > 0;
		bool notRunningLeftOrRight = h == 0;
		bool notRunningAll = notRunningForwardOrBackward && notRunningLeftOrRight;

		if (runningForward){
			_animation.Blend ("RunForward");
			_animation.Blend ("Idle", 0);
			_animation.Blend ("RunBackward", 0);
		} else if (runningBackward){
			_animation.Blend ("RunForward");
			_animation.Blend ("Idle", 0);
			_animation.Blend ("RunBackward", 0);	
		} else if (notRunningForwardOrBackward){
			_animation.Blend ("RunForward", 0);
			_animation.Blend ("RunBackward", 0);		
		}


		if ((runnigForwardOrStanding && runnigRight) || (runningBackward && runningLeft)) {
			_animation.Blend ("RunRight");
			_animation.Blend ("Idle", 0);
			_animation.Blend ("RunLeft", 0);
		} else if ((runnigForwardOrStanding && runningLeft) || (runningBackward && runnigRight)) {
			_animation.Blend ("RunLeft");
			_animation.Blend ("Idle", 0);
			_animation.Blend ("RunRight", 0);
		} else if (notRunningLeftOrRight) {
			_animation.Blend ("RunLeft", 0);
			_animation.Blend ("RunRight", 0);
		} if (notRunningAll) {
			_animation.Blend("Idle");
		}
		
	}
}
