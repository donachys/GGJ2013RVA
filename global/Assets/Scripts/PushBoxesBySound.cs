using UnityEngine;
using System.Collections;

public class PushBoxesBySound : MonoBehaviour 
{
// Update is called once per frame
	void Update () 
	{
		

	
	}
	void OnTriggerStay( Collider col){
		if (col.attachedRigidbody && col.tag == "PushableBySound" && AudioInput.volume >= 0.8)
        col.attachedRigidbody.AddForce( transform.forward * 100);
		//transform.parent.gameObject.GetComponent();
		Debug.Log("this " + transform.forward);//parent.gameObject.GetComponent("CharacterController").rotation);
		//Debug.Log("up "+ Vector3.up);
		/*if(col.tag == "PushableBySound"){
		Debug.Log (col.tag,col);
		//Debug.Log(AudioInput.volume);
		}*/
	}
	
}