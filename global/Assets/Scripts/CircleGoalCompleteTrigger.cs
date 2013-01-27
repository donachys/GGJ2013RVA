using UnityEngine;
using System.Collections;

public class CircleGoalCompleteTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			Debug.Log ("Circle Goal Completed");
			GoalTracker.goal2 = true;
		}
		//play victory sound
	}
}
