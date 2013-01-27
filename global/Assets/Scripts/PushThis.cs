using System;
using UnityEngine;
using System.Collections;

public class PushThis : MonoBehaviour
{

	private float timer = 1;
	
	
	
	//public CharacterController cc;
	public PushThis ()
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		
		Vector3 closestPoint = Player.currentPosition;
		
		float distance = Vector3.Distance(closestPoint, transform.position);
		//Debug.Log ("Closest" + distance);
		
		if(distance <=10.5 && AudioInput.smoothedVolume >= 0.7F){
			Debug.Log ("Adding Force");
			collider.attachedRigidbody.AddForce((Player.lookDirection* 50 * distance)+(Vector3.up*25));	
			
			if ( timer < 0 )
			{
				PlayAudio();
				timer = 1;
			}
		}
	
	}
	
	void PlayAudio()
	{
		Messenger.Broadcast("DingMe");
	}

}
