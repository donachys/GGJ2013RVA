using UnityEngine;
using System.Collections;

public class leafset4Lightup : MonoBehaviour {
	public Material litmaterial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalTracker.goal2){
		renderer.material = litmaterial;	
		}
	}
}
