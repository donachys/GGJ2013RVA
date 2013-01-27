using UnityEngine;
using System.Collections;

public class leafset3Lightup : MonoBehaviour {
	public Material litmaterial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalTracker.goal1){
		renderer.material = litmaterial;	
		}
	}
}
