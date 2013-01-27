using UnityEngine;
using System.Collections;

public class TestSphere : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		Vector3 newScale = new Vector3( AudioInput.smoothedVolume, AudioInput.smoothedVolume, AudioInput.smoothedVolume );
		
		newScale *= 3;
		
		transform.localScale = newScale;
	
	}
}
