using UnityEngine;
using System.Collections;

public class WaterfallGoalCompleteTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Player"){
			Debug.Log ("Waterfall Goal Completed");
			GoalTracker.goal1 = true;
		}
		//play victory sound
	}
}
