using UnityEngine;
using System.Collections;

public class leafset2Lightup : MonoBehaviour {
	public Material litmaterial;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalTracker.goal3){
		renderer.material = litmaterial;	
		}
	}
}
